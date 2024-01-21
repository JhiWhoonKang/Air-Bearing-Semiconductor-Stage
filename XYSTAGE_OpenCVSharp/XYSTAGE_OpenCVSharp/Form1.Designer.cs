namespace XYSTAGE_OpenCVSharp
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
            this.pictureBoxIpl1 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxIpl2 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.pictureBoxIpl3 = new OpenCvSharp.UserInterface.PictureBoxIpl();
            this.lb_cX = new System.Windows.Forms.Label();
            this.lb_cXV = new System.Windows.Forms.Label();
            this.lb_cY = new System.Windows.Forms.Label();
            this.lb_cYV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIpl1
            // 
            this.pictureBoxIpl1.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxIpl1.Name = "pictureBoxIpl1";
            this.pictureBoxIpl1.Size = new System.Drawing.Size(563, 480);
            this.pictureBoxIpl1.TabIndex = 0;
            this.pictureBoxIpl1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 33;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBoxIpl2
            // 
            this.pictureBoxIpl2.Location = new System.Drawing.Point(658, 12);
            this.pictureBoxIpl2.Name = "pictureBoxIpl2";
            this.pictureBoxIpl2.Size = new System.Drawing.Size(563, 480);
            this.pictureBoxIpl2.TabIndex = 1;
            this.pictureBoxIpl2.TabStop = false;
            // 
            // pictureBoxIpl3
            // 
            this.pictureBoxIpl3.Location = new System.Drawing.Point(1304, 12);
            this.pictureBoxIpl3.Name = "pictureBoxIpl3";
            this.pictureBoxIpl3.Size = new System.Drawing.Size(563, 480);
            this.pictureBoxIpl3.TabIndex = 2;
            this.pictureBoxIpl3.TabStop = false;
            // 
            // lb_cX
            // 
            this.lb_cX.AutoSize = true;
            this.lb_cX.Location = new System.Drawing.Point(1306, 501);
            this.lb_cX.Name = "lb_cX";
            this.lb_cX.Size = new System.Drawing.Size(20, 12);
            this.lb_cX.TabIndex = 3;
            this.lb_cX.Text = "cX";
            // 
            // lb_cXV
            // 
            this.lb_cXV.AutoSize = true;
            this.lb_cXV.Location = new System.Drawing.Point(1350, 501);
            this.lb_cXV.Name = "lb_cXV";
            this.lb_cXV.Size = new System.Drawing.Size(0, 12);
            this.lb_cXV.TabIndex = 4;
            // 
            // lb_cY
            // 
            this.lb_cY.AutoSize = true;
            this.lb_cY.Location = new System.Drawing.Point(1306, 527);
            this.lb_cY.Name = "lb_cY";
            this.lb_cY.Size = new System.Drawing.Size(20, 12);
            this.lb_cY.TabIndex = 5;
            this.lb_cY.Text = "cY";
            // 
            // lb_cYV
            // 
            this.lb_cYV.AutoSize = true;
            this.lb_cYV.Location = new System.Drawing.Point(1350, 527);
            this.lb_cYV.Name = "lb_cYV";
            this.lb_cYV.Size = new System.Drawing.Size(0, 12);
            this.lb_cYV.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1879, 572);
            this.Controls.Add(this.lb_cYV);
            this.Controls.Add(this.lb_cY);
            this.Controls.Add(this.lb_cXV);
            this.Controls.Add(this.lb_cX);
            this.Controls.Add(this.pictureBoxIpl3);
            this.Controls.Add(this.pictureBoxIpl2);
            this.Controls.Add(this.pictureBoxIpl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIpl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl1;
        private System.Windows.Forms.Timer timer1;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl2;
        private OpenCvSharp.UserInterface.PictureBoxIpl pictureBoxIpl3;
        private System.Windows.Forms.Label lb_cX;
        private System.Windows.Forms.Label lb_cXV;
        private System.Windows.Forms.Label lb_cY;
        private System.Windows.Forms.Label lb_cYV;
    }
}

