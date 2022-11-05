namespace Labeling
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLabelingCV = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLabelingResult = new System.Windows.Forms.TextBox();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.radBin = new System.Windows.Forms.RadioButton();
            this.radOtus = new System.Windows.Forms.RadioButton();
            this.hscThreshold = new System.Windows.Forms.HScrollBar();
            this.chkCam = new System.Windows.Forms.CheckBox();
            this.btnEdge = new System.Windows.Forms.Button();
            this.btnLabelingK = new System.Windows.Forms.Button();
            this.btnToBin = new System.Windows.Forms.Button();
            this.btnToGray = new System.Windows.Forms.Button();
            this.btnWebCam = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.picBin = new System.Windows.Forms.PictureBox();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.picSrc = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timCam = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLabelingCV
            // 
            this.btnLabelingCV.Location = new System.Drawing.Point(775, 211);
            this.btnLabelingCV.Name = "btnLabelingCV";
            this.btnLabelingCV.Size = new System.Drawing.Size(102, 48);
            this.btnLabelingCV.TabIndex = 60;
            this.btnLabelingCV.Text = "Labeling(CV)";
            this.btnLabelingCV.UseVisualStyleBackColor = true;
            this.btnLabelingCV.Click += new System.EventHandler(this.btnLabelingCV_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(330, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(330, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "Gray";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Binarized";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 56;
            this.label1.Text = "Source";
            // 
            // txtLabelingResult
            // 
            this.txtLabelingResult.Location = new System.Drawing.Point(658, 331);
            this.txtLabelingResult.Multiline = true;
            this.txtLabelingResult.Name = "txtLabelingResult";
            this.txtLabelingResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLabelingResult.Size = new System.Drawing.Size(350, 273);
            this.txtLabelingResult.TabIndex = 55;
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(937, 155);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(11, 12);
            this.lblThreshold.TabIndex = 54;
            this.lblThreshold.Text = "0";
            // 
            // radBin
            // 
            this.radBin.AutoSize = true;
            this.radBin.Location = new System.Drawing.Point(824, 151);
            this.radBin.Name = "radBin";
            this.radBin.Size = new System.Drawing.Size(59, 16);
            this.radBin.TabIndex = 53;
            this.radBin.Text = "Binary";
            this.radBin.UseVisualStyleBackColor = true;
            this.radBin.CheckedChanged += new System.EventHandler(this.radBin_CheckedChanged);
            // 
            // radOtus
            // 
            this.radOtus.AutoSize = true;
            this.radOtus.Checked = true;
            this.radOtus.Location = new System.Drawing.Point(769, 151);
            this.radOtus.Name = "radOtus";
            this.radOtus.Size = new System.Drawing.Size(49, 16);
            this.radOtus.TabIndex = 52;
            this.radOtus.TabStop = true;
            this.radOtus.Text = "Otus";
            this.radOtus.UseVisualStyleBackColor = true;
            this.radOtus.CheckedChanged += new System.EventHandler(this.radOtus_CheckedChanged);
            // 
            // hscThreshold
            // 
            this.hscThreshold.LargeChange = 1;
            this.hscThreshold.Location = new System.Drawing.Point(766, 175);
            this.hscThreshold.Maximum = 255;
            this.hscThreshold.Name = "hscThreshold";
            this.hscThreshold.Size = new System.Drawing.Size(228, 23);
            this.hscThreshold.TabIndex = 51;
            this.hscThreshold.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hscThreshold_Scroll);
            // 
            // chkCam
            // 
            this.chkCam.AutoSize = true;
            this.chkCam.Location = new System.Drawing.Point(883, 28);
            this.chkCam.Name = "chkCam";
            this.chkCam.Size = new System.Drawing.Size(15, 14);
            this.chkCam.TabIndex = 50;
            this.chkCam.UseVisualStyleBackColor = true;
            // 
            // btnEdge
            // 
            this.btnEdge.Location = new System.Drawing.Point(658, 272);
            this.btnEdge.Name = "btnEdge";
            this.btnEdge.Size = new System.Drawing.Size(102, 48);
            this.btnEdge.TabIndex = 49;
            this.btnEdge.Text = "Canny Edge";
            this.btnEdge.UseVisualStyleBackColor = true;
            this.btnEdge.Click += new System.EventHandler(this.btnEdge_Click);
            // 
            // btnLabelingK
            // 
            this.btnLabelingK.Location = new System.Drawing.Point(658, 211);
            this.btnLabelingK.Name = "btnLabelingK";
            this.btnLabelingK.Size = new System.Drawing.Size(102, 48);
            this.btnLabelingK.TabIndex = 48;
            this.btnLabelingK.Text = "Labeling(K)";
            this.btnLabelingK.UseVisualStyleBackColor = true;
            this.btnLabelingK.Click += new System.EventHandler(this.btnLabelingK_Click);
            // 
            // btnToBin
            // 
            this.btnToBin.Location = new System.Drawing.Point(658, 150);
            this.btnToBin.Name = "btnToBin";
            this.btnToBin.Size = new System.Drawing.Size(102, 48);
            this.btnToBin.TabIndex = 47;
            this.btnToBin.Text = "To Binary";
            this.btnToBin.UseVisualStyleBackColor = true;
            this.btnToBin.Click += new System.EventHandler(this.btnToBin_Click);
            // 
            // btnToGray
            // 
            this.btnToGray.Location = new System.Drawing.Point(658, 89);
            this.btnToGray.Name = "btnToGray";
            this.btnToGray.Size = new System.Drawing.Size(102, 48);
            this.btnToGray.TabIndex = 46;
            this.btnToGray.Text = "To Gray";
            this.btnToGray.UseVisualStyleBackColor = true;
            this.btnToGray.Click += new System.EventHandler(this.btnToGray_Click);
            // 
            // btnWebCam
            // 
            this.btnWebCam.Location = new System.Drawing.Point(775, 28);
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.Size = new System.Drawing.Size(102, 48);
            this.btnWebCam.TabIndex = 45;
            this.btnWebCam.Text = "WebCam";
            this.btnWebCam.UseVisualStyleBackColor = true;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebCam_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(658, 28);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(102, 48);
            this.btnReadFile.TabIndex = 44;
            this.btnReadFile.Text = "Read File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // picResult
            // 
            this.picResult.BackColor = System.Drawing.Color.White;
            this.picResult.Location = new System.Drawing.Point(333, 331);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(306, 273);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResult.TabIndex = 43;
            this.picResult.TabStop = false;
            // 
            // picBin
            // 
            this.picBin.BackColor = System.Drawing.Color.White;
            this.picBin.Location = new System.Drawing.Point(12, 331);
            this.picBin.Name = "picBin";
            this.picBin.Size = new System.Drawing.Size(306, 273);
            this.picBin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBin.TabIndex = 42;
            this.picBin.TabStop = false;
            // 
            // picGray
            // 
            this.picGray.BackColor = System.Drawing.Color.White;
            this.picGray.Location = new System.Drawing.Point(333, 28);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(306, 273);
            this.picGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGray.TabIndex = 41;
            this.picGray.TabStop = false;
            // 
            // picSrc
            // 
            this.picSrc.BackColor = System.Drawing.Color.White;
            this.picSrc.Image = ((System.Drawing.Image)(resources.GetObject("picSrc.Image")));
            this.picSrc.Location = new System.Drawing.Point(12, 28);
            this.picSrc.Name = "picSrc";
            this.picSrc.Size = new System.Drawing.Size(306, 273);
            this.picSrc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSrc.TabIndex = 40;
            this.picSrc.TabStop = false;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // timCam
            // 
            this.timCam.Tick += new System.EventHandler(this.timCam_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 619);
            this.Controls.Add(this.btnLabelingCV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLabelingResult);
            this.Controls.Add(this.lblThreshold);
            this.Controls.Add(this.radBin);
            this.Controls.Add(this.radOtus);
            this.Controls.Add(this.hscThreshold);
            this.Controls.Add(this.chkCam);
            this.Controls.Add(this.btnEdge);
            this.Controls.Add(this.btnLabelingK);
            this.Controls.Add(this.btnToBin);
            this.Controls.Add(this.btnToGray);
            this.Controls.Add(this.btnWebCam);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picBin);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.picSrc);
            this.Name = "Form1";
            this.Text = "OpenCV";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSrc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLabelingCV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLabelingResult;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.RadioButton radBin;
        private System.Windows.Forms.RadioButton radOtus;
        private System.Windows.Forms.HScrollBar hscThreshold;
        private System.Windows.Forms.CheckBox chkCam;
        private System.Windows.Forms.Button btnEdge;
        private System.Windows.Forms.Button btnLabelingK;
        private System.Windows.Forms.Button btnToBin;
        private System.Windows.Forms.Button btnToGray;
        private System.Windows.Forms.Button btnWebCam;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.PictureBox picBin;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.PictureBox picSrc;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timCam;
    }
}

