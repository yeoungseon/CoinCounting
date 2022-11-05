using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace Labeling
{
    static class LabelingK
    {
        //=================================================================
        //  Label을 구함. thresholdArea보다 면적이 큰 것만 찾음
        //  isObjWhite=true이면 흰색이 물체.
        //=================================================================
        public static unsafe Mat[] getLabels(Mat matBin, int thresholdArea, bool isObjWhite)
        {
            byte objColor = (byte)(isObjWhite ? 255 : 0);
            byte backColor = (byte)(isObjWhite ? 0 : 255);

            int i, j;
            int w = matBin.Width;
            int h = matBin.Height;

            byte* ptr = (byte*)matBin.DataPointer; // 화소 데이터에의 포인터

            //--------------------------------------------------------
            //  임시로 레이블을 저장할 메모리 공간과 등가 테이블 생성
            //--------------------------------------------------------
            int[,] Map = new int[h, w];
            int[,] eq_tbl = new int[10000, 2];

            //---------------------------------------------------------
            //  첫 번째 스캔 - 초기 레이블 지정 및 등가 테이블 생성
            //---------------------------------------------------------
            int label = 0, maxl, minl, min_eq;
            for (j = 1; j < h; j++)
            {
                for (i = 1; i < w; i++)
                {
                    long offset = (w * j) + (i * 1);
                    if (ptr[offset] == objColor)   //Object pixel이면
                    {
                        //바로 위 픽셀과 왼쪽 픽셀 모두에 레이블이 존재하는 경우
                        if ((Map[j - 1, i] != 0) && (Map[j, i - 1] != 0))
                        {
                            if (Map[j - 1, i] == Map[j, i - 1])
                            {
                                //두레이블이 서로 같은 경우
                                Map[j, i] = Map[j - 1, i];
                            }
                            else
                            {
                                //두 레이블이 서로 다른경우, 작은 레이블을 부여
                                maxl = Math.Max(Map[j - 1, i], Map[j, i - 1]);
                                minl = Math.Min(Map[j - 1, i], Map[j, i - 1]);

                                Map[j, i] = minl;
                                //등가 테이블 조정
                                min_eq = Math.Min(eq_tbl[maxl, 1], eq_tbl[minl, 1]);
                                eq_tbl[maxl, 1] = min_eq;
                                eq_tbl[minl, 1] = min_eq;
                            }
                        }
                        else if (Map[j - 1, i] != 0)
                        {
                            //바로 위 픽셀에만 레이블이 존재할 경우
                            Map[j, i] = Map[j - 1, i];
                        }
                        else if (Map[j, i - 1] != 0)
                        {
                            //바로 왼쪽 필셀에만 레이블이 존재할 경우
                            Map[j, i] = Map[j, i - 1];
                        }
                        else
                        {
                            //이웃에 레이블이 존재하지 않으면 새로운 레이블을 부여
                            label++;
                            Map[j, i] = label;
                            eq_tbl[label, 0] = label;
                            eq_tbl[label, 1] = label;
                        }
                    }
                }
            }

            //---------------------------------------------------------
            //  등가 테이블 정리
            //---------------------------------------------------------
            int temp;
            for (i = 1; i <= label; i++)
            {
                temp = eq_tbl[i, 1];
                if (temp != eq_tbl[i, 0]) eq_tbl[i, 1] = eq_tbl[temp, 1];
            }
            //등가 테이블의 레이블을 1부터 차례대로 증가시키기
            int[] hash = new int[label + 1];
            for (i = 1; i <= label; i++) hash[eq_tbl[i, 1]] = eq_tbl[i, 1];
            int cnt = 1;
            for (i = 1; i <= label; i++) if (hash[i] != 0) hash[i] = cnt++;
            for (i = 1; i <= label; i++) eq_tbl[i, 1] = hash[eq_tbl[i, 1]];

            //---------------------------------------------------------
            // 두번째 스캔 - 등가 테이블을 이용하여 모든 픽셀에 고유 레이블 부여
            //---------------------------------------------------------
            byte[,] newPtr = new byte[h, w];
            for (j = 1; j < h; j++)
                for (i = 1; i < w; i++)
                {
                    if (Map[j, i] != 0)
                    {
                        temp = Map[j, i];
                        newPtr[j, i] = (byte)(eq_tbl[temp, 1]);
                    }
                }

            cnt = cnt - 1;

            //---------------------------------------------------------
            //  세번째 스캔 - 부여된 레이블번째 배열 이미지로 저장
            //---------------------------------------------------------
            Mat[] matlabel = new Mat[cnt];

            int width = matBin.Width;
            int height = matBin.Height;
            for (int k = 0; k < cnt; k++)
            {
                int npixels_label = 0; // 레이블당 픽셀 개수 세본다.
                Mat buffimg = new Mat(height, width, MatType.CV_8UC1);
                byte* ptrtemp = (byte*)buffimg.DataPointer;
                int buff_H = buffimg.Height;
                int buff_W = buffimg.Width;
                for (j = 0; j < buff_H; j++)
                    for (i = 0; i < buff_W; i++)
                    {
                        long offset = (buff_W * j) + (i * 1);
                        if (newPtr[j, i] == k + 1)
                        {
                            ptrtemp[offset] = objColor;
                            npixels_label++;
                        }
                        else
                        {
                            ptrtemp[offset] = backColor;
                        }
                    }
                if (npixels_label >= thresholdArea) matlabel[k] = buffimg.Clone();
            }

            //---------------------------------------------------------
            // return할 image 만들기. 배열에 null이 있으면 제거
            //---------------------------------------------------------
            int cntreturnimg = 0;
            for (int k = 0; k < cnt; k++)
            {
                if (matlabel[k] != null) cntreturnimg++;
            }
            Mat[] iplReturn = new Mat[cntreturnimg];
            cntreturnimg = 0;
            for (int k = 0; k < cnt; k++)
            {
                if (matlabel[k] != null)
                {
                    iplReturn[cntreturnimg] = matlabel[k].Clone();
                    cntreturnimg++;
                }
            }
            return iplReturn;
        }

        //=================================================================
        //  object의 면적과 중심 구하기
        //=================================================================
        public static unsafe void getAreaCenter(Mat mat, bool isObjWhite,
                                    out int area, out double xcen, out double ycen)
        {
            byte objColor = (byte)(isObjWhite ? 255 : 0);

            xcen = ycen = area = 0;

            byte* ptr = (byte*)mat.DataPointer;   // 화소 데이터에의 포인터
            int buff_H = mat.Height;
            int buff_W = mat.Width;
            for (int j = 0; j < buff_H; j++)
                for (int i = 0; i < buff_W; i++)
                {
                    long offset = (buff_W * j) + (i * 1);
                    if (ptr[offset] == objColor)
                    {
                        area++;
                        xcen += i;
                        ycen += j;
                    }
                }

            xcen = xcen / area;
            ycen = ycen / area;
        }
    }
}
