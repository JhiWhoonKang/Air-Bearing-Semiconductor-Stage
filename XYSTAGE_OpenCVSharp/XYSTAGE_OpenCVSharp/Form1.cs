using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;

namespace XYSTAGE_OpenCVSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CvCapture capture;
        IplImage src;
        XYSTAGE_OpenCVClass Convert = new XYSTAGE_OpenCVClass();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capture = CvCapture.FromCamera(CaptureDevice.DShow, 1);
                capture.SetCaptureProperty(CaptureProperty.FrameWidth, 640);
                capture.SetCaptureProperty(CaptureProperty.FrameHeight, 480);                            
            }
            catch
            {
                timer1.Enabled = false;
            }
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            src = capture.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;

            #region detect contour
            pictureBoxIpl2.ImageIpl = Convert.Contour(src);
            #endregion

            #region detect moment
            var MomentResult = Convert.Moment(src);
            pictureBoxIpl3.ImageIpl = MomentResult.Item1;
            lb_cXV.Text = MomentResult.Item2.ToString();
            lb_cYV.Text = MomentResult.Item3.ToString();

            Point center = new Point(MomentResult.Item2, MomentResult.Item3);
            MoveToCenter(center);
            #endregion
        }

        private void MoveToCenter(Point center)
        {
            Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(center.X));
            Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(center.Y));

            Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, true);
            Form1.Ads.WriteAny(Form1.hY_AbMove_Ex, true);

            while (true)   // 움직일동안 대기 
            {
                if (Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Busy, typeof(bool))) == false && Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_Busy, typeof(bool))) == false) break;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cv.ReleaseImage(src);
            if (src != null) src.Dispose();
        }
    }
}