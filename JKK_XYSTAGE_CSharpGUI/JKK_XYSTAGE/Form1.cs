using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace JKK_XYSTAGE
{
    public partial class Form1 : Form
    {
        public static TcAdsClient Ads = new TcAdsClient();

        public static  PTP_Form PTP_form = new PTP_Form();
        public static  PID_X_Form PID_X_form = new PID_X_Form();
        public static  PID_Y_Form PID_Y_form = new PID_Y_Form();

        #region Twincat_ADS_Parameter

        public static int hOnMoterX;
        public static int hOnMoterY;

        public static int hX_AbMove_Ex;
        public static int hY_AbMove_Ex;

        public static int hX_Command_Vel;
        public static int hX_Command_Acc;
        public static int hX_Command_Dec;
        public static int hX_Busy;
        public static int hX_Done;
        public static int hY_Command_Vel;
        public static int hY_Command_Acc;
        public static int hY_Command_Dec;
        public static int hY_Busy;
        public static int hX_Command_Pos;
        public static int hY_Command_Pos;

        // PID //
        public static int hX_Gain;
        public static int hX_COE_Ex;

        public static int hY_Gain;
        public static int hY_COE_Ex;

        public static int h_COE_Index;
        public static int h_success;

        public static int hX_Vel;
        public static int hX_Pos;
        public static int hY_Vel;
        public static int hY_Pos;

        public static int hX_GetP_Gain;
        public static int hX_GetI_Gain;
        public static int hX_GetD_Gain;
        public static int hX_GetPID_Ex;

        // @@
        public static int hY_GetP_Gain;
        public static int hY_GetI_Gain;
        public static int hY_GetD_Gain;
        public static int hY_GetPID_Ex;
        #endregion


        //Stage states
        public static bool x_on = false;
        public static bool y_on = false;



        public Form1()
        {
            InitializeComponent();
            //1. 화면 크기 고정
            this.MaximumSize = new Size(1600, 900);
            this.MinimumSize = new Size(1600, 900);
            // 


            menuStrip1.Items[1].Enabled = false;
            menuStrip1.Items[2].Enabled = false;


            PTP_form.MdiParent = this;
            PID_X_form.MdiParent = this;
            PID_Y_form.MdiParent = this;

            PTP_form.StartPosition = FormStartPosition.Manual;
            PID_X_form.StartPosition = FormStartPosition.Manual;
            PID_Y_form.StartPosition = FormStartPosition.Manual;

            PTP_form.Location = new Point(this.ClientRectangle.Left, this.ClientRectangle.Top);
            PID_X_form.Location = new Point(this.ClientRectangle.Left, this.ClientRectangle.Top);
            PID_Y_form.Location = new Point(this.ClientRectangle.Left, this.ClientRectangle.Top);

            PTP_form.Size = this.ClientSize;
            PID_X_form.Size = this.ClientSize;
            PID_Y_form.Size = this.ClientSize;
  


        }

        private void pTPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PID_X_form.Hide();
            PID_Y_form.Hide();
            PTP_form.Size = this.ClientSize;

            PTP_form.Show();
        }
        private void x축ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PID_Y_form.Hide();
            PTP_form.Hide();

            PID_X_form.Size = this.ClientSize;
            PID_X_form.Show();
        }

        private void y축ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PID_X_form.Hide();
            PTP_form.Hide();

            PID_Y_form.Size = this.ClientSize;
            PID_Y_form.Show();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Ads.Connect("5.33.182.40.1.1", 851);
            if(Ads.IsConnected)
            {
                MessageBox.Show("Target과 연결되었습니다.", "통신 연결",
                         MessageBoxButtons.OK, MessageBoxIcon.Information);
                connectToolStripMenuItem.ForeColor = Color.Yellow;
                connectToolStripMenuItem.BackColor = Color.SkyBlue;
                connectToolStripMenuItem.Text = "Connected";
                menuStrip1.Items[0].Enabled = false;
                menuStrip1.Items[1].Enabled = true;
                menuStrip1.Items[2].Enabled = true;

                hOnMoterX = Ads.CreateVariableHandle("GVL.OnMoterX");
                hOnMoterY = Ads.CreateVariableHandle("GVL.OnMoterY");                
                hX_Command_Vel = Ads.CreateVariableHandle("GVL.X_Command_Vel");
                hX_Command_Acc = Ads.CreateVariableHandle("GVL.X_Command_Acc");
                hX_Command_Dec = Ads.CreateVariableHandle("GVL.X_Command_Dec");
                hX_Busy = Ads.CreateVariableHandle("GVL.X_Busy");
                hY_Command_Vel = Ads.CreateVariableHandle("GVL.Y_Command_Vel");
                hY_Command_Acc = Ads.CreateVariableHandle("GVL.Y_Command_Acc");
                hY_Command_Dec = Ads.CreateVariableHandle("GVL.Y_Command_Dec");
                hY_Busy = Ads.CreateVariableHandle("GVL.Y_Busy");
                hX_Command_Pos = Ads.CreateVariableHandle("GVL.X_Command_Pos");
                hY_Command_Pos = Ads.CreateVariableHandle("GVL.Y_Command_Pos");
                hX_AbMove_Ex = Ads.CreateVariableHandle("GVL.X_AbMove_Ex");
                hY_AbMove_Ex = Ads.CreateVariableHandle("GVL.Y_AbMove_Ex");

                hX_Gain = Ads.CreateVariableHandle("GVL.X_Gain");
                hY_Gain = Ads.CreateVariableHandle("GVL.Y_Gain");

                hX_COE_Ex = Ads.CreateVariableHandle("GVL.X_COE_Ex");
                hY_COE_Ex = Ads.CreateVariableHandle("GVL.Y_COE_Ex");

                h_COE_Index = Ads.CreateVariableHandle("GVL.Index");
                h_success= Ads.CreateVariableHandle("GVL.Success");

                hX_Vel = Ads.CreateVariableHandle("GVL.X_Vel");
                hX_Pos = Ads.CreateVariableHandle("GVL.X_Pos");
                hY_Vel = Ads.CreateVariableHandle("GVL.Y_Vel");
                hY_Pos = Ads.CreateVariableHandle("GVL.Y_Pos");

                hX_GetP_Gain = Ads.CreateVariableHandle("GVL.X_GetP_Gain");
                hX_GetI_Gain = Ads.CreateVariableHandle("GVL.X_GetI_Gain");
                hX_GetD_Gain = Ads.CreateVariableHandle("GVL.X_GetD_Gain");
                hX_GetPID_Ex = Ads.CreateVariableHandle("GVL.X_CoERead_EX");

                hY_GetP_Gain= Ads.CreateVariableHandle("GVL.Y_GetP_Gain");
                hY_GetI_Gain= Ads.CreateVariableHandle("GVL.Y_GetI_Gain");
                hY_GetD_Gain= Ads.CreateVariableHandle("GVL.Y_GetD_Gain");
                hY_GetPID_Ex = Ads.CreateVariableHandle("GVL.Y_CoERead_EX");

                hX_Done = Ads.CreateVariableHandle("GVL.X_Done");

                     PID_X_form.Display_PID_Gain();
                  PID_Y_form.Display_PID_Gain();
            }
            else
            {
                MessageBox.Show("1. Target AMS Net ID를 확인하세요\n2. Target 전원을 확인하세요\n3. Runtime 상태를 확인하세요", "ADS 통신 오류",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                
        
            }

        }



        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Ads.IsConnected)
            {
                Ads.WriteAny(hOnMoterX, false);
                Ads.WriteAny(hOnMoterY, false);
                Ads.Disconnect();
            }
        }
    }
}
