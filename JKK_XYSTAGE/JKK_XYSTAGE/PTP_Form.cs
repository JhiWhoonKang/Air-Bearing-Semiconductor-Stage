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
    public partial class PTP_Form : Form
    {
        #region 그래프 변수 
        Graphics g;
        int Margin = 40;  // pl_stage와 user stage의 간격
        
        Rectangle client_stage;//user stage Rect
        Point client_home; // user stage의 홈 좌표
        Point client_max;  // user stage의 최대 좌표
        
        // Mouse Event
        Point Mouse_Point;
        List<Point> user_point_list = new List<Point>(); // 스테이지 명령용
        List<Point> stage_point_list = new List<Point>(); // 스테이지 가시화용
        List<Point> feed_pos_list = new List<Point>(); // feedback 
        //

        //정확한 값은 알아봐야함
        double x_MaxPos = 140.0; 
        double y_MaxPos = 140.0;
        //

        // 이동 횟수 디폴트 5번 
        int Move_num=5;

        bool EXFLAG = false;
        Point CurPos;
        #endregion

        string pos, No,state;


        public PTP_Form()
        {
            InitializeComponent();
            g = pl_stage.CreateGraphics(); // pl_stage에 그림을 그리기 위한 Graphics 객체 생성
            client_stage = new Rectangle(Margin, Margin, pl_stage.Width - 2 * Margin, pl_stage.Height - 2 * Margin);
            client_home = new Point(client_stage.Width + Margin, Margin); // 우상단
            client_max = new Point(client_home.X - client_stage.Width, client_stage.Height + Margin); //좌하단       
        }

        public void InitStage()
        {
            string Left_Top = "(" + x_MaxPos.ToString() + "," + (0).ToString() + ")";
            string Right_Top = "(" + (0).ToString() + "," + (0).ToString() + ")";
            string Left_Bottom = "(" + x_MaxPos.ToString() + "," + y_MaxPos.ToString() + ")";
            string Right_Bottom = "(" + (0).ToString() + "," + y_MaxPos.ToString() + ")";
            int gap = 13;
            g.FillRectangle(Brushes.White, pl_stage.ClientRectangle);
            g.DrawRectangle(Pens.Red, client_stage);
            g.DrawString(Right_Top, Font, Brushes.Black,client_home.X - gap, client_home.Y- gap);
            g.DrawString(Left_Top, Font, Brushes.Black, client_max.X - gap, Margin - gap);
            g.DrawString(Left_Bottom, Font, Brushes.Black, client_max.X - gap, client_max.Y + gap);
            g.DrawString(Right_Bottom, Font, Brushes.Black, client_home.X - gap, client_max.Y + gap);
        }

        /*pl Events*/
        private void pl_stage_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Point = pl_stage.PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));

            if (feed_pos_list.Count == 0 && rb_FeedLine.Checked) { feed_pos_list.Add(Mouse_Point); }
            
            /*
                user stage <=> panel stage [Mapping]
                x (user stage x) , X (Mouse_pt_x)
                x = (x_MaxPos / client_rect_width)(Home.X - X)  
                
                y (user stage y) , Y (Mouse_pt_y)
                y = (y_MaxPos / client_rect_height)(Y-Margin)      
             */

            int x = Convert.ToInt32((x_MaxPos / client_stage.Width)*(client_home.X - Mouse_Point.X));
            int y = Convert.ToInt32((y_MaxPos / client_stage.Height) * ( Mouse_Point.Y - Margin));
            Point user_point = new Point(x, y);
           
            //리스트 뷰에 띄우는 
            No = user_point_list.Count.ToString();
            pos = "[" + user_point.X.ToString() + "," + user_point.Y.ToString() + "]";
            state = "Wait"; 
            ListViewItem lvi = new ListViewItem(new string[] { No, pos, state });


            if (x>=0 && x <= x_MaxPos && y>=0 && y<=y_MaxPos)
            {
                //1. user 지정 좌표, stage 좌표 list에 저장
                user_point_list.Add(user_point);
                stage_point_list.Add(Mouse_Point);
                //2. 스테이지 이동 예상 경로 표시
                if (user_point_list.Count > 1)
                {
                    g.DrawLine(Pens.Red, stage_point_list[stage_point_list.Count - 2], stage_point_list[stage_point_list.Count - 1]);
                }
                //3. user 지정 좌표 가시화 [x,y] 문자 표시
                string Point_display = "["+user_point.X.ToString() + "," + user_point.Y.ToString()+"]";  
                g.DrawString(Point_display, Font, Brushes.Blue, Mouse_Point.X - 23, Mouse_Point.Y + 12);
                //4. user 지정 좌표 가시화 ㅁ 초록색 사각형 표시
                g.FillRectangle(Brushes.Green, new Rectangle(Mouse_Point.X - 3, Mouse_Point.Y - 3, 6, 6));

                listView2.Items.Add(lvi);
                
                if (user_point_list.Count == Move_num) //5개 찍으면 동작
                {
                    EXFLAG = true;
                    Thread PTP_thread = new Thread(new ThreadStart(PTP_Function));
                    PTP_thread.Start();
                }
            }
            else 
            {
                MessageBox.Show("스테이지를 벗어난 좌표입니다.", "위치 지정 오류",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void PTP_Function()
        {
            int list_state_cnt = 0;   
            while (user_point_list.Count != 0)
            {
              
                Point tmp = user_point_list[0];
                user_point_list.RemoveAt(0);
                             
                Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(tmp.X));
                Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(tmp.Y));

                Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, true);
                Form1.Ads.WriteAny(Form1.hY_AbMove_Ex, true);



                listView2.Items[list_state_cnt].SubItems[2].Text = "Run";

                while (true)   // 움직일동안 대기 
                { 
                    if (Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Busy, typeof(bool))) ==false && Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_Busy, typeof(bool))) == false) break;
                }


                if (rb_FeedLine.Checked)   //피드백 받아서 선 긋기
                {
                    tb_xCommandPos.Text = "XPos: " + tmp.X.ToString();
                    tb_yCommandPos.Text = "YPos: " + tmp.Y.ToString();
                    double xRpos = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hX_Pos, typeof(double)));
                    double xRvel = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hX_Vel, typeof(double)));
                    double yRpos = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hY_Pos, typeof(double)));
                    double yRvel = Convert.ToDouble(Form1.Ads.ReadAny(Form1.hY_Vel, typeof(double)));
                    tb_xFeedPos.Text = xRpos.ToString();
                    tb_xFeedVel.Text = xRvel.ToString();
                    tb_yFeedPos.Text = yRpos.ToString();
                    tb_yFeedVel.Text = yRvel.ToString();


                    CurPos.X = client_home.X - (int)((xRpos * client_stage.Width) / x_MaxPos);
                    CurPos.Y = Margin + (int)((yRpos * client_stage.Height) / y_MaxPos);
                    feed_pos_list.Add(CurPos);

                    if (feed_pos_list.Count > 1)
                    {
                        g.DrawLine(Pens.Black, feed_pos_list[feed_pos_list.Count - 2], feed_pos_list[feed_pos_list.Count - 1]);
                    }
                }

                g.FillRectangle(Brushes.Yellow, new Rectangle(stage_point_list[list_state_cnt].X - 3, stage_point_list[list_state_cnt].Y - 3, 6, 6));
                list_state_cnt++;
                MessageBox.Show(tmp.X.ToString() + " " + tmp.Y.ToString());
            }


            if(rb_CP.Checked)    //원 그리기
            {

            }


            Thread.Sleep(1000);
            user_point_list.Clear();
            stage_point_list.Clear();
            list_state_cnt = 0;
            InitStage();
        }


        //pl Events End
        private void PTP_Form_Shown(object sender, EventArgs e)
        {
            InitStage();
        }


        private void bt_xServoOn_Click(object sender, EventArgs e)
        {
            if (!Form1.x_on)
            {
                Form1.Ads.WriteAny(Form1.hOnMoterX, true);
                Form1.x_on = true;
                bt_xServoOn.Text = "Servo Off";
                Form1.PID_X_form.bt_Motor_On.Text = "Servo Off";
                Form1.lb_Servo_X.BackColor = Color.Yellow;
                Form1.lb_Servo_X.Text = "Servo_X : On";
            }
            else
            {
                Form1.Ads.WriteAny(Form1.hOnMoterX, false);
                Form1.x_on = false;
                bt_xServoOn.Text = "Servo On";
                Form1.PID_X_form.bt_Motor_On.Text = "Servo On";
                Form1.lb_Servo_X.BackColor = Color.Gray;
                Form1.lb_Servo_X.Text = "Servo_X : Off";
            }
        }
        private void bt_yServoOn_Click(object sender, EventArgs e)
        {
            if (!Form1.y_on)
            {
                Form1.Ads.WriteAny(Form1.hOnMoterY, true);
                Form1.y_on = true;
                bt_yServoOn.Text = "Servo Off";
                Form1.lb_Servo_Y.BackColor = Color.Yellow;
                Form1.lb_Servo_Y.Text = "Servo_Y : On";
            }
            else
            {
                Form1.Ads.WriteAny(Form1.hOnMoterY, false);
                Form1.y_on = false;
                bt_yServoOn.Text = "Servo On";
                Form1.lb_Servo_Y.BackColor = Color.Gray;
                Form1.lb_Servo_Y.Text = "Servo_X : Off";
            }
        }



        // 파라미터 입력 예외 <최대 속도 제한 아직 구현 x>
        private void tb_xVel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_xAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_xDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_yVel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_yAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void tb_yDec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                MessageBox.Show("숫자를 입력하세요", "입력 오류",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }

        private void bt_xPosClr_Click(object sender, EventArgs e)
        {

        }

        private void bt_xHome_Click(object sender, EventArgs e)
        {
            if (Form1.Ads.IsConnected)
            {
              Form1.Ads.WriteAny(Form1.hX_Command_Pos, Convert.ToDouble(0));
              Form1.Ads.WriteAny(Form1.hX_Command_Vel, Convert.ToDouble(50));
              Form1.Ads.WriteAny(Form1.hX_Command_Acc, Convert.ToDouble(50));
              Form1.Ads.WriteAny(Form1.hX_Command_Dec, Convert.ToDouble(0));
              Form1.Ads.WriteAny(Form1.hX_AbMove_Ex, true);
            }
        }
        private void bt_yHome_Click(object sender, EventArgs e)
        {
            if (Form1.Ads.IsConnected)
            {
                Form1.Ads.WriteAny(Form1.hY_Command_Pos, Convert.ToDouble(0));
                Form1.Ads.WriteAny(Form1.hY_Command_Vel, Convert.ToDouble(50));
                Form1.Ads.WriteAny(Form1.hY_Command_Acc, Convert.ToDouble(50));
                Form1.Ads.WriteAny(Form1.hY_Command_Dec, Convert.ToDouble(0));
                Form1.Ads.WriteAny(Form1.hY_AbMove_Ex, true);
            }
        }

        private void bt_xAlarmClr_Click(object sender, EventArgs e)
        {

        }

        private void bt_listView_Reset_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
        }

        private void bt_Set_MoveNum_Click(object sender, EventArgs e)
        {
            Move_num = int.Parse(tb_MoveNum.Text.ToString());
        }

        private void PTP_Form_Load(object sender, EventArgs e)
        {
            Form1.PID_X_form.Display_PID_Gain();
        }

      
    }
}
