using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using OpenCvSharp.Blob;

namespace Labeling
{
    static class LabelingCV
    {
        //=================================================================
        //  Binary Mat를 받아 Blob을 찾음
        //=================================================================
        public static CvBlob[] FindBlobs(Mat matBin, out Mat resultMat)
        {
            // CvBlobs 실행 후 결과 객체 생성 !!!
            CvBlobs blobs = new CvBlobs(matBin);

            // result Mat 만들기
            resultMat = new Mat(matBin.Height, matBin.Width, MatType.CV_8UC3);  // CV_8UC3 = 색필요
            blobs.RenderBlobs(matBin, resultMat, RenderBlobsMode.BoundingBox);
            blobs.RenderBlobs(matBin, resultMat, RenderBlobsMode.Color);
            blobs.RenderBlobs(matBin, resultMat, RenderBlobsMode.Centroid);

            // 찾아진 blob들을 리스트에 추가
            List<CvBlob> blobList = new List<CvBlob>();
            foreach (KeyValuePair<int, CvBlob> item in blobs)
            {
                blobList.Add(item.Value);
            }

            return blobList.ToArray();
        }

        //=================================================================
        //  Blob의 면적과 중심 구하기
        //=================================================================
        public static void getAreaCenter(CvBlob blob, out int area, out double xcen, out double ycen)
        {
            area = blob.Area;

            Point2d pt2D = blob.Centroid;
            xcen = pt2D.X;
            ycen = pt2D.Y;
        }
    }
}
