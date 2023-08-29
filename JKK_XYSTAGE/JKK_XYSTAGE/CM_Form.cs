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
    public partial class CM_Form : Form
    {
        #region Graph Variables
        Graphics g;
        int Margin = 40;

        Rectangle client_stage;
        Point client_home;
        Point client_max;

        Point Mouse_Point;
        List<Point> user_point_list = new List<Point>();
        List<Point> stage_point_listj = new List<Point>();
        List<Point> feed_pos_list = new List<Point>();

        double x_MaxPos = 140.0;
        double y_MaxPos = 140.0;

        int Move_num = 5;

        bool EXFALG = false;
        Point CurPos;
        #endregion

        public CM_Form()
        {
            InitializeComponent();
            g = pl_stage.CreateGraphics();
            client_stage = new Rectangle(Margin, Margin, pl_stage.Width - 2 * Margin, pl_stage.Height - 2 * Margin);
            client_home = new Point(client_stage.Width + Margin, Margin);
            client_max=new Point(client_home.X-client_stage.Width,client_stage.Height+Margin);
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

        private void pl_stage_MouseDown(object sender, MouseEventArgs e)
        {
            Mouse_Point=pl_stage.PointToClient(new Point(Control.MousePosition.X, Control.MousePosition.Y));

            if (feed_pos_list.Count == 0)
            {

            }
        }
    }
}
