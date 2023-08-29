using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKK_XYSTAGE
{
    public partial class PID_Y_Form : Form
    {
        double[] x_time = new double[0];
        double[] y_vel = new double[0];
        double[] y_pos = new double[0];

        double _y_vel = 0;
        double _y_pos = 0;

        double Real_time = 0;
        UInt32 timer_tick = 0;


        Crosshair cross;
        public PID_Y_Form()
        {
            InitializeComponent();
            InitPlot();
            Y_Gain_Plot.MouseMove += Y_Gain_Plot_MouseMove;
        }

        public void InitPlot()
        {
   
             Y_Gain_Plot.Plot.SetAxisLimits(yMin: 0, yMax: 10);
             Y_Gain_Plot.Plot.XAxis.SetBoundary(min: 0, max: 2);
            
        }

        private void Y_Gain_Plot_MouseMove(object sender, MouseEventArgs e)
        {
            Crosshair crosshair = cross;
            if (crosshair != null)
            {
                (double x, double y) = Y_Gain_Plot.GetMouseCoordinates();
                crosshair.X = x;
                crosshair.Y = y;
                Y_Gain_Plot.Render();
            }
        }

        private void bt_P_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hY_Gain, Convert.ToInt16(tb_P_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3100", 16)); //@@
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, true);

            Display_PID_Gain();
        }

        private void bt_I_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hY_Gain, Convert.ToInt16(tb_I_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3102", 16)); //@@
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, true);
            Display_PID_Gain();
        }

        private void bt_D_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hY_Gain, Convert.ToInt16(tb_D_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3101", 16)); //@@
            Form1.Ads.WriteAny(Form1.hY_COE_Ex, true);
            Display_PID_Gain();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_Busy, typeof(bool))))
            {
                bt_Simulation.Text = "Run";
                bt_Simulation.ForeColor = Color.Red;
            }
            else if (!(Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_Busy, typeof(bool)))))
            {
                bt_Simulation.Text = "Simul";
                bt_Simulation.ForeColor = Color.Black;
            }

            Real_time = timer_tick * 0.01;

            _y_vel = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hY_Vel, typeof(double)));
            _y_pos = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hY_Pos, typeof(double)));

            x_time = x_time.Append(Real_time).ToArray();
            y_vel = y_vel.Append(_y_vel).ToArray();
            y_pos = y_pos.Append(_y_pos).ToArray();

            Y_Gain_Plot.Plot.AddScatter(x_time, y_vel, color: Color.Red, 0.1f, 0.1f, ScottPlot.MarkerShape.filledDiamond, ScottPlot.LineStyle.Solid);
            Y_Gain_Plot.Plot.AddScatter(x_time, y_pos, color: Color.Blue, 0.1f, 0.1f, ScottPlot.MarkerShape.filledDiamond, ScottPlot.LineStyle.Solid);

            Y_Gain_Plot.Plot.AxisAuto();

            Y_Gain_Plot.Render();
            timer_tick++;
            Display_PID_Gain();
        }

        public void Display_PID_Gain()
        {

            Form1.Ads.WriteAny(Form1.hY_GetPID_Ex, true);
            this.Invoke(
            (MethodInvoker)(() =>
            {
                tb_Y_Get_P.Text = (Form1.Ads.ReadAny(Form1.hY_GetP_Gain, typeof(Int32))).ToString();
                tb_Y_Get_I.Text = (Form1.Ads.ReadAny(Form1.hY_GetI_Gain, typeof(Int32))).ToString();
                tb_Y_Get_D.Text = (Form1.Ads.ReadAny(Form1.hY_GetD_Gain, typeof(Int32))).ToString();
            }));

            Form1.PTP_form.Invoke(
           (MethodInvoker)(() =>
           {
               Form1.PTP_form.tb_yPGain.Text = (Form1.Ads.ReadAny(Form1.hY_GetP_Gain, typeof(Int32))).ToString();
               Form1.PTP_form.tb_yIGain.Text = (Form1.Ads.ReadAny(Form1.hY_GetI_Gain, typeof(Int32))).ToString();
               Form1.PTP_form.tb_yDGain.Text = (Form1.Ads.ReadAny(Form1.hY_GetD_Gain, typeof(Int32))).ToString();
           }));

            Form1.Ads.WriteAny(Form1.hY_GetPID_Ex, false);

        }

        private void bt_Gain_ReSet_Click(object sender, EventArgs e)
        {
            this.Invoke(
            (MethodInvoker)(() =>
            {
                Y_Gain_Plot.Plot.Clear();
                Y_Gain_Plot.Reset(Y_Gain_Plot.Plot);
                Y_Gain_Plot.Refresh();
            }));
        }

        private void bt_Motor_On_Click(object sender, EventArgs e)
        {
            if (!Form1.y_on)
            {
                Form1.Ads.WriteAny(Form1.hOnMoterY, true);
                Form1.y_on = true;
                bt_Motor_On.Text = "Servo Off";
                Form1.PTP_form.bt_yServoOn.Text = "Servo Off";
                Form1.lb_Servo_Y.BackColor = Color.Yellow;
                Form1.lb_Servo_Y.Text = "Servo_Y : On";
            }
            else
            {
                Form1.Ads.WriteAny(Form1.hOnMoterY, false);
                Form1.y_on = false;
                bt_Motor_On.Text = "Servo On";
                Form1.PTP_form.bt_yServoOn.Text = "Servo On";
                Form1.lb_Servo_Y.BackColor = Color.Gray;
                Form1.lb_Servo_Y.Text = "Servo_Y : Off";
            }
        }

        private void bt_Gr_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_Simul_ParaSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(int.Parse(tb_ypos_ref.Text))); //@@
            Form1.Ads.WriteAny(Form1.hY_Command_Vel, Convert.ToDouble(int.Parse(tb_yvel_ref.Text))); //@@
            Form1.Ads.WriteAny(Form1.hY_Command_Acc, Convert.ToDouble(int.Parse(tb_yvel_ref.Text))); //@@
            Form1.Ads.WriteAny(Form1.hY_Command_Dec, Convert.ToDouble(0));
        }

        private void bt_Gr_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cross = Y_Gain_Plot.Plot.AddCrosshair(0, 0);
            Display_PID_Gain();
            for (int i = 0; i < y_vel.Length; i++)
                y_vel[i] = 0;

            for (int i = 0; i < x_time.Length; i++)
                x_time[i] = 0;

            for (int i = 0; i < y_pos.Length; i++)
                y_pos[i] = 0;

            timer_tick = 0;
            Array.Resize(ref y_vel, 1);
            Array.Resize(ref x_time, 1);
            Array.Resize(ref y_pos, 1);
        }

        private void bt_Simulation_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(Form1.Ads.ReadAny(Form1.hY_Pos, typeof(double))) == 0)
                Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(int.Parse(tb_yvel_ref.Text)));

            if (Convert.ToInt32(Form1.Ads.ReadAny(Form1.hY_Pos, typeof(double)))
                    == Convert.ToInt32(int.Parse(tb_yvel_ref.Text)))
                MessageBox.Show("Homing 을 해주세요. 현재위치와 이동하고자 하는 위치가 같습니다.");

            if (!(Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_AbMove_Ex, typeof(bool)))))
                Form1.Ads.WriteAny(Form1.hY_AbMove_Ex, true);
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            if (Form1.Ads.IsConnected)
            {
                Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(0));

                if (tb_yvel_ref.Text != string.Empty)
                {
                    Form1.Ads.WriteAny(Form1.hY_Command_Vel, Convert.ToDouble(int.Parse(tb_yvel_ref.Text)));
                    Form1.Ads.WriteAny(Form1.hY_Command_Acc, Convert.ToDouble(int.Parse(tb_yvel_ref.Text)));
                }
                else if (tb_yvel_ref.Text == string.Empty)
                {
                    Form1.Ads.WriteAny(Form1.hY_Command_Vel, Convert.ToDouble(100));
                    Form1.Ads.WriteAny(Form1.hY_Command_Acc, Convert.ToDouble(100));
                }
                Form1.Ads.WriteAny(Form1.hY_AbMove_Ex, true);
            }
        }

        private void PID_Y_Form_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            Display_PID_Gain();
            Y_Gain_Plot.Plot.Title("[ Y Axis PID Tuning Graph ]", null, null, 18.0f, null);
            Y_Gain_Plot.Refresh();
        }
    }
}
