﻿
namespace JKK_XYSTAGE
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x축ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.y축ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lb_Servo_X = new System.Windows.Forms.Label();
            lb_Servo_Y = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.pTPToolStripMenuItem,
            this.pIDToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(847, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // pTPToolStripMenuItem
            // 
            this.pTPToolStripMenuItem.Name = "pTPToolStripMenuItem";
            this.pTPToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.pTPToolStripMenuItem.Text = "PTP";
            this.pTPToolStripMenuItem.Click += new System.EventHandler(this.pTPToolStripMenuItem_Click);
            // 
            // pIDToolStripMenuItem
            // 
            this.pIDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x축ToolStripMenuItem,
            this.y축ToolStripMenuItem});
            this.pIDToolStripMenuItem.Name = "pIDToolStripMenuItem";
            this.pIDToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.pIDToolStripMenuItem.Text = "PID";
            // 
            // x축ToolStripMenuItem
            // 
            this.x축ToolStripMenuItem.Name = "x축ToolStripMenuItem";
            this.x축ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.x축ToolStripMenuItem.Text = "X Axis";
            this.x축ToolStripMenuItem.Click += new System.EventHandler(this.x축ToolStripMenuItem_Click);
            // 
            // y축ToolStripMenuItem
            // 
            this.y축ToolStripMenuItem.Name = "y축ToolStripMenuItem";
            this.y축ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.y축ToolStripMenuItem.Text = "Y Axis";
            this.y축ToolStripMenuItem.Click += new System.EventHandler(this.y축ToolStripMenuItem_Click);
            // 
            // lb_Servo_X
            //
         lb_Servo_X.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         lb_Servo_X.AutoSize = true;
         lb_Servo_X.BackColor = System.Drawing.Color.Gray;
         lb_Servo_X.Location = new System.Drawing.Point(675, 7);
         lb_Servo_X.Name = "lb_Servo_X";
         lb_Servo_X.Size = new System.Drawing.Size(78, 12);
         lb_Servo_X.TabIndex = 2;
         lb_Servo_X.Text = "Servo_X : Off";
            // 
            // lb_Servo_Y
            // 
        lb_Servo_Y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        lb_Servo_Y.AutoSize = true;
        lb_Servo_Y.BackColor = System.Drawing.Color.Gray;
        lb_Servo_Y.Location = new System.Drawing.Point(760, 7);
        lb_Servo_Y.Name = "lb_Servo_Y";
        lb_Servo_Y.Size = new System.Drawing.Size(78, 12);
        lb_Servo_Y.TabIndex = 3;
        lb_Servo_Y.Text = "Servo_Y : Off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(847, 478);
            this.Controls.Add(lb_Servo_Y);
            this.Controls.Add(lb_Servo_X);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x축ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem y축ToolStripMenuItem;
        public static System.Windows.Forms.Label lb_Servo_X;
        public static System.Windows.Forms.Label lb_Servo_Y;
    }
}

