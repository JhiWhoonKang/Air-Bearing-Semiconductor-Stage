using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JKK_XYSTAGE
{
    public partial class PID_X_Form : Form
    {
        double[] x_time = new double[0];
        double[] y_vel = new double[0];
        double[] y_pos = new double[0];

        double _x_vel = 0;
        double _x_pos = 0;

        double Real_time = 0;
        UInt32 timer_tick = 0;


        Crosshair cross;

        public PID_X_Form()
        {
            InitializeComponent();
            InitPlot();
            X_Gain_Plot.MouseMove += X_Gain_Plot_MouseMove;
     
        }

        private void X_Gain_Plot_MouseMove(object sender, MouseEventArgs e)
        {
            Crosshair crosshair = cross;
            if (crosshair != null)
            {
                (double x, double y) = X_Gain_Plot.GetMouseCoordinates();
                crosshair.X = x;
                crosshair.Y = y;
                X_Gain_Plot.Render();
            }


        }

        private void bt_P_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hX_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hX_Gain, Convert.ToInt16(tb_P_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3100",16));
            Form1.Ads.WriteAny(Form1.hX_COE_Ex,true);
           
            Display_PID_Gain();
        }

        private void bt_I_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hX_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hX_Gain, Convert.ToInt16(tb_I_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3102", 16));
            Form1.Ads.WriteAny(Form1.hX_COE_Ex, true);
            Display_PID_Gain();

        }

        private void bt_D_GainSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hX_COE_Ex, false);
            Form1.Ads.WriteAny(Form1.hX_Gain, Convert.ToInt16(tb_D_Gain.Text));
            Form1.Ads.WriteAny(Form1.h_COE_Index, Convert.ToUInt16("3101", 16));
            Form1.Ads.WriteAny(Form1.hX_COE_Ex, true);
            Display_PID_Gain();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Busy, typeof(bool))))
            {
                bt_Simulation.Text = "Run";
                bt_Simulation.ForeColor = Color.Red;
            }
            else if (!(Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Busy, typeof(bool)))))
            {
                bt_Simulation.Text = "Simul";
                bt_Simulation.ForeColor = Color.Black;
            }

            Real_time = timer_tick*0.01;

            _x_vel = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hX_Vel, typeof(double)));
            _x_pos = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hX_Pos, typeof(double)));


            x_time = x_time.Append(Real_time).ToArray();
            y_vel = y_vel.Append(_x_vel).ToArray();
            y_pos = y_pos.Append(_x_pos).ToArray();

            X_Gain_Plot.Plot.AddScatter(x_time, y_vel, color: Color.Red, 0.1f, 0.1f, ScottPlot.MarkerShape.filledDiamond, ScottPlot.LineStyle.Solid);
            X_Gain_Plot.Plot.AddScatter(x_time, y_pos, color: Color.Blue, 0.1f, 0.1f, ScottPlot.MarkerShape.filledDiamond, ScottPlot.LineStyle.Solid);

            X_Gain_Plot.Plot.AxisAuto();

            X_Gain_Plot.Render();
            timer_tick++;
            Display_PID_Gain();
        }

        private void bt_Gr_Start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void bt_Simul_ParaSet_Click(object sender, EventArgs e)
        {
            Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(int.Parse(tb_xpos_ref.Text)));
            Form1.Ads.WriteAny(Form1.hX_Command_Vel, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));
            Form1.Ads.WriteAny(Form1.hX_Command_Acc, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));
            Form1.Ads.WriteAny(Form1.hX_Command_Dec, Convert.ToDouble(0));
        }

        private void bt_Gr_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            cross = X_Gain_Plot.Plot.AddCrosshair(0, 0);

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
            if(Convert.ToDouble(Form1.Ads.ReadAny(Form1.hX_Pos, typeof(double))) ==0)
                Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));

            if (Convert.ToInt32(Form1.Ads.ReadAny(Form1.hX_Pos, typeof(double)))
                    == Convert.ToInt32(int.Parse(tb_xvel_ref.Text)))
                MessageBox.Show("Homing 을 해주세요. 현재위치와 이동하고자 하는 위치가 같습니다.");

            if (!(Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_AbMove_Ex, typeof(bool)))))
                    Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, true);
       
        }

        private void bt_Home_Click(object sender, EventArgs e)
        {
            if (Form1.Ads.IsConnected)
            {
                Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(0));

                if (tb_xvel_ref.Text != string.Empty)
                {
                    Form1.Ads.WriteAny(Form1.hX_Command_Vel, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));
                    Form1.Ads.WriteAny(Form1.hX_Command_Acc, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));
                }
                else if(tb_xvel_ref.Text == string.Empty)
                {
                    Form1.Ads.WriteAny(Form1.hX_Command_Vel, Convert.ToDouble(100));
                    Form1.Ads.WriteAny(Form1.hX_Command_Acc, Convert.ToDouble(100));
                }
                Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, true);

                //if ((Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Done, typeof(bool)))))
                //{
                //    Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, false);
                //    Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(int.Parse(tb_xvel_ref.Text)));
                //}
            }
        }

        private void PID_X_Form_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            Display_PID_Gain();
            X_Gain_Plot.Plot.Title("[ X Axis PID Tuning Graph ]", null, null, 18.0f, null);
            X_Gain_Plot.Refresh();
        }

        private void bt_Motor_On_Click(object sender, EventArgs e)
        {
            if (!Form1.x_on)
            {
                Form1.Ads.WriteAny(Form1.hOnMoterX, true);
                Form1.x_on = true;
                bt_Motor_On.Text = "Servo Off";
                Form1.PTP_form.bt_xServoOn.Text= "Servo Off";
                Form1.lb_Servo_X.BackColor = Color.Yellow;
                Form1.lb_Servo_X.Text = "Servo_X : On";
            }
            else
            {
                Form1.Ads.WriteAny(Form1.hOnMoterX, false);
                Form1.x_on = false;
                bt_Motor_On.Text = "Servo On";
                Form1.PTP_form.bt_xServoOn.Text = "Servo On";
                Form1.lb_Servo_X.BackColor = Color.Gray;
                Form1.lb_Servo_X.Text = "Servo_X : Off";
            }
        }

        private void bt_Gain_ReSet_Click(object sender, EventArgs e)
        {
            this.Invoke(
            (MethodInvoker)(() =>
            {
                X_Gain_Plot.Plot.Clear();
                X_Gain_Plot.Reset(X_Gain_Plot.Plot);
                X_Gain_Plot.Refresh();
            }));
        }
        
        public void Display_PID_Gain()
        {

            if (Form1.Ads.IsConnected)
            {
                Form1.Ads.WriteAny(Form1.hX_GetPID_Ex, true);
                this.Invoke(
                (MethodInvoker)(() =>
                {
                    tb_X_Get_P.Text = (Form1.Ads.ReadAny(Form1.hX_GetP_Gain, typeof(Int32))).ToString();
                    tb_X_Get_I.Text = (Form1.Ads.ReadAny(Form1.hX_GetI_Gain, typeof(Int32))).ToString();
                    tb_X_Get_D.Text = (Form1.Ads.ReadAny(Form1.hX_GetD_Gain, typeof(Int32))).ToString();
                }));

                // Form1.PTP_form.tb_xPGain.Text= (Form1.Ads.ReadAny(Form1.hX_GetP_Gain, typeof(Int32))).ToString();
                // Form1.PTP_form.tb_xIGain.Text = (Form1.Ads.ReadAny(Form1.hX_GetI_Gain, typeof(Int32))).ToString();
                // Form1.PTP_form.tb_xDGain.Text = (Form1.Ads.ReadAny(Form1.hX_GetD_Gain, typeof(Int32))).ToString();

                Form1.PTP_form.Invoke(
               (MethodInvoker)(() =>
               {
                   Form1.PTP_form.tb_xPGain.Text = (Form1.Ads.ReadAny(Form1.hX_GetP_Gain, typeof(Int32))).ToString();
                   Form1.PTP_form.tb_xIGain.Text = (Form1.Ads.ReadAny(Form1.hX_GetI_Gain, typeof(Int32))).ToString();
                   Form1.PTP_form.tb_xDGain.Text = (Form1.Ads.ReadAny(Form1.hX_GetD_Gain, typeof(Int32))).ToString();
               }));

                Form1.Ads.WriteAny(Form1.hX_GetPID_Ex, false);
            }

        }


        public void InitPlot()
        {
          //  X_Gain_Plot.Plot.

            X_Gain_Plot.Plot.SetAxisLimits( xMin: 0, xMax:10);
            X_Gain_Plot.Plot.XAxis.SetBoundary(min: 0, max: 10);
        }
    }
}
