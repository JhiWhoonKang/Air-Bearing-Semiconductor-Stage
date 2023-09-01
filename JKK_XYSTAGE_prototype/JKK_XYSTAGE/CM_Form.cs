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
    public partial class CM_Form : Form
    {
        #region Graph-related variables
        Graphics g;
        int Margin = 40;  // pl_stage와 user stage의 간격

        /* Stage */
        Rectangle client_stage;//user stage Rect
        Point client_home; // user stage의 홈 좌표
        Point client_max;  // user stage의 최대 좌표
        Point CurPos; // Current Position

        // @@
        double x_MaxPos = 140.0; // Maximum X-coordinate value
        double y_MaxPos = 140.0; // Maximum Y-coordinate value
        /* */

        /* Mouse Event-related variables */
        Point Mouse_Point;
        List<Point> user_point_list = new List<Point>(); // 스테이지 명령용
        List<Point> stage_point_list = new List<Point>(); // 스테이지 가시화용
        List<Point> feed_pos_list = new List<Point>(); // feedback 
        /* */

        /* Motion-relatec Variables */
        int Side_num = 6; // 꼭짓점 수 6 default
        int Radius = 10; // 반지름 10 default
        /* */

        bool EXFLAG = false;
        #endregion


        string pos, No, state;
        public CM_Form()
        {
            InitializeComponent();
            g = pl_stage.CreateGraphics();
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
            g.DrawString(Right_Top, Font, Brushes.Black, client_home.X - gap, client_home.Y - gap);
            g.DrawString(Left_Top, Font, Brushes.Black, client_max.X - gap, Margin - gap);
            g.DrawString(Left_Bottom, Font, Brushes.Black, client_max.X - gap, client_max.Y + gap);
            g.DrawString(Right_Bottom, Font, Brushes.Black, client_home.X - gap, client_max.Y + gap);
        }

        /*pl Events*/
        int x, y;
        double nx, ny;
        Point user_point;
        private void pl_stage_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Point = pl_stage.PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));

            if (feed_pos_list.Count == 0)
            {
                feed_pos_list.Add(Mouse_Point);
            }

            x = Convert.ToInt32((x_MaxPos / client_stage.Width) * (client_home.X - Mouse_Point.X));
            y = Convert.ToInt32((y_MaxPos / client_stage.Height) * (Mouse_Point.Y - Margin));
            for(int i = 0; i < Side_num; i++)
            {
                double angle = 2 * Math.PI * i / Side_num;
                //nx = x + Radius * Math.Cos(360 / Side_num * i);
                //ny = y + Radius * Math.Sin(360 / Side_num * i);
                nx = x + Radius * Math.Cos(angle);
                ny = y + Radius * Math.Sin(angle);

                if (nx >= 0 && nx <= x_MaxPos && ny >= 0 && ny <= y_MaxPos)
                {
                    user_point = new Point((int)nx, (int)ny);
                    user_point_list.Add(user_point);
                    stage_point_list.Add(Mouse_Point);

                    No = user_point_list.Count.ToString(); // 개수를 string으로 저장
                    pos = "[" + user_point.X.ToString() + "," + user_point.Y.ToString() + "]"; // 현재좌표
                    state = "Wait";
                    ListViewItem lvi = new ListViewItem(new string[] { No, pos, state });

                    if (user_point_list.Count > 1)
                    {
                        g.DrawLine(Pens.Red, stage_point_list[stage_point_list.Count - 2], stage_point_list[stage_point_list.Count - 1]);
                    }

                    string Point_display = "[" + user_point.X.ToString() + "," + user_point.Y.ToString() + "]"; //현재 좌표
                    g.DrawString(Point_display, Font, Brushes.Blue, Mouse_Point.X - 23, Mouse_Point.Y + 12);
                    g.FillRectangle(Brushes.Green, new Rectangle(Mouse_Point.X - 3, Mouse_Point.Y - 3, 6, 6));

                    listView2.Items.Add(lvi);

                    EXFLAG = true;

                    Thread CM_thread = new Thread(new ThreadStart(CM_Function));
                    CM_thread.Start();
                }

                else
                {
                    MessageBox.Show("스테이지를 벗어난 좌표입니다.", "위치 지정 오류",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                    user_point_list.Clear();
                    stage_point_list.Clear();
                    InitStage();
                }
            }
        }

        private void CM_Function()
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

                while (true)
                {
                    if (Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hX_Busy, typeof(bool))) == false && Convert.ToBoolean(Form1.Ads.ReadAny(Form1.hY_Busy, typeof(bool))) == false) break;
                }

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
            
                g.FillRectangle(Brushes.Yellow, new Rectangle(stage_point_list[list_state_cnt].X - 3, stage_point_list[list_state_cnt].Y - 3, 6, 6));
                list_state_cnt++;
                MessageBox.Show(tmp.X.ToString() + " " + tmp.Y.ToString());
            }

            Thread.Sleep(1000);
            user_point_list.Clear();
            stage_point_list.Clear();
            list_state_cnt = 0;
            InitStage();
        }

        private void bt_Set_MoveNum_Click(object sender, EventArgs e)
        {
            Side_num = int.Parse(tb_SideNum.Text.ToString());
        }

        private void bt_Set_Radius_Click(object sender, EventArgs e)
        {
            Radius=int.Parse(tb_Radius.Text.ToString());
        }
    }
}
