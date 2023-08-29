
namespace JKK_XYSTAGE
{
    partial class PTP_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pl_stage = new System.Windows.Forms.Panel();
            this.bt_xServoOn = new System.Windows.Forms.Button();
            this.bt_xAlarmClr = new System.Windows.Forms.Button();
            this.bt_xHome = new System.Windows.Forms.Button();
            this.bt_xPosClr = new System.Windows.Forms.Button();
            this.bt_xSstop = new System.Windows.Forms.Button();
            this.bt_xEstop = new System.Windows.Forms.Button();
            this.tb_xVel = new System.Windows.Forms.TextBox();
            this.tb_xAcc = new System.Windows.Forms.TextBox();
            this.tb_xDec = new System.Windows.Forms.TextBox();
            this.tb_xFeedVel = new System.Windows.Forms.TextBox();
            this.tb_xFeedPos = new System.Windows.Forms.TextBox();
            this.tb_xCommandPos = new System.Windows.Forms.TextBox();
            this.tb_xDGain = new System.Windows.Forms.TextBox();
            this.tb_xIGain = new System.Windows.Forms.TextBox();
            this.tb_xPGain = new System.Windows.Forms.TextBox();
            this.gb_xGroup = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.bt_yServoOn = new System.Windows.Forms.Button();
            this.bt_yAlarmClr = new System.Windows.Forms.Button();
            this.bt_yHome = new System.Windows.Forms.Button();
            this.bt_yPosClr = new System.Windows.Forms.Button();
            this.bt_ySstop = new System.Windows.Forms.Button();
            this.bt_yEstop = new System.Windows.Forms.Button();
            this.tb_yVel = new System.Windows.Forms.TextBox();
            this.tb_yAcc = new System.Windows.Forms.TextBox();
            this.tb_yDec = new System.Windows.Forms.TextBox();
            this.tb_yCommandPos = new System.Windows.Forms.TextBox();
            this.tb_yFeedPos = new System.Windows.Forms.TextBox();
            this.tb_yFeedVel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_yPGain = new System.Windows.Forms.TextBox();
            this.tb_yDGain = new System.Windows.Forms.TextBox();
            this.tb_yIGain = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.bt_Set_MoveNum = new System.Windows.Forms.Button();
            this.tb_MoveNum = new System.Windows.Forms.TextBox();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.bt_listView_Reset = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.rb_CP = new System.Windows.Forms.RadioButton();
            this.rb_FeedLine = new System.Windows.Forms.RadioButton();
            this.gb_xGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_stage
            // 
            this.pl_stage.BackColor = System.Drawing.Color.White;
            this.pl_stage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pl_stage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pl_stage.Location = new System.Drawing.Point(309, 148);
            this.pl_stage.Name = "pl_stage";
            this.pl_stage.Size = new System.Drawing.Size(550, 550);
            this.pl_stage.TabIndex = 0;
            this.pl_stage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pl_stage_MouseDown);
            // 
            // bt_xServoOn
            // 
            this.bt_xServoOn.Location = new System.Drawing.Point(231, 41);
            this.bt_xServoOn.Name = "bt_xServoOn";
            this.bt_xServoOn.Size = new System.Drawing.Size(75, 23);
            this.bt_xServoOn.TabIndex = 0;
            this.bt_xServoOn.Text = "Servo On";
            this.bt_xServoOn.UseVisualStyleBackColor = true;
            this.bt_xServoOn.Click += new System.EventHandler(this.bt_xServoOn_Click);
            // 
            // bt_xAlarmClr
            // 
            this.bt_xAlarmClr.Location = new System.Drawing.Point(231, 68);
            this.bt_xAlarmClr.Name = "bt_xAlarmClr";
            this.bt_xAlarmClr.Size = new System.Drawing.Size(75, 23);
            this.bt_xAlarmClr.TabIndex = 1;
            this.bt_xAlarmClr.Text = "Alarm Clr";
            this.bt_xAlarmClr.UseVisualStyleBackColor = true;
            this.bt_xAlarmClr.Click += new System.EventHandler(this.bt_xAlarmClr_Click);
            // 
            // bt_xHome
            // 
            this.bt_xHome.Location = new System.Drawing.Point(231, 95);
            this.bt_xHome.Name = "bt_xHome";
            this.bt_xHome.Size = new System.Drawing.Size(75, 23);
            this.bt_xHome.TabIndex = 2;
            this.bt_xHome.Text = "Home";
            this.bt_xHome.UseVisualStyleBackColor = true;
            this.bt_xHome.Click += new System.EventHandler(this.bt_xHome_Click);
            // 
            // bt_xPosClr
            // 
            this.bt_xPosClr.Location = new System.Drawing.Point(231, 144);
            this.bt_xPosClr.Name = "bt_xPosClr";
            this.bt_xPosClr.Size = new System.Drawing.Size(75, 23);
            this.bt_xPosClr.TabIndex = 3;
            this.bt_xPosClr.Text = "Pos Clr";
            this.bt_xPosClr.UseVisualStyleBackColor = true;
            this.bt_xPosClr.Click += new System.EventHandler(this.bt_xPosClr_Click);
            // 
            // bt_xSstop
            // 
            this.bt_xSstop.Location = new System.Drawing.Point(231, 169);
            this.bt_xSstop.Name = "bt_xSstop";
            this.bt_xSstop.Size = new System.Drawing.Size(75, 23);
            this.bt_xSstop.TabIndex = 4;
            this.bt_xSstop.Text = "SSTOP";
            this.bt_xSstop.UseVisualStyleBackColor = true;
            // 
            // bt_xEstop
            // 
            this.bt_xEstop.Location = new System.Drawing.Point(231, 196);
            this.bt_xEstop.Name = "bt_xEstop";
            this.bt_xEstop.Size = new System.Drawing.Size(75, 23);
            this.bt_xEstop.TabIndex = 5;
            this.bt_xEstop.Text = "ESTOP";
            this.bt_xEstop.UseVisualStyleBackColor = true;
            // 
            // tb_xVel
            // 
            this.tb_xVel.Location = new System.Drawing.Point(142, 41);
            this.tb_xVel.Name = "tb_xVel";
            this.tb_xVel.Size = new System.Drawing.Size(71, 21);
            this.tb_xVel.TabIndex = 12;
            this.tb_xVel.Text = "200";
            this.tb_xVel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xVel_KeyPress);
            // 
            // tb_xAcc
            // 
            this.tb_xAcc.Location = new System.Drawing.Point(142, 68);
            this.tb_xAcc.Name = "tb_xAcc";
            this.tb_xAcc.Size = new System.Drawing.Size(71, 21);
            this.tb_xAcc.TabIndex = 13;
            this.tb_xAcc.Text = "200";
            this.tb_xAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xAcc_KeyPress);
            // 
            // tb_xDec
            // 
            this.tb_xDec.Location = new System.Drawing.Point(142, 97);
            this.tb_xDec.Name = "tb_xDec";
            this.tb_xDec.Size = new System.Drawing.Size(71, 21);
            this.tb_xDec.TabIndex = 14;
            this.tb_xDec.Text = "200";
            this.tb_xDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_xDec_KeyPress);
            // 
            // tb_xFeedVel
            // 
            this.tb_xFeedVel.Location = new System.Drawing.Point(142, 200);
            this.tb_xFeedVel.Name = "tb_xFeedVel";
            this.tb_xFeedVel.ReadOnly = true;
            this.tb_xFeedVel.Size = new System.Drawing.Size(71, 21);
            this.tb_xFeedVel.TabIndex = 17;
            // 
            // tb_xFeedPos
            // 
            this.tb_xFeedPos.Location = new System.Drawing.Point(142, 173);
            this.tb_xFeedPos.Name = "tb_xFeedPos";
            this.tb_xFeedPos.ReadOnly = true;
            this.tb_xFeedPos.Size = new System.Drawing.Size(71, 21);
            this.tb_xFeedPos.TabIndex = 16;
            // 
            // tb_xCommandPos
            // 
            this.tb_xCommandPos.Location = new System.Drawing.Point(142, 146);
            this.tb_xCommandPos.Name = "tb_xCommandPos";
            this.tb_xCommandPos.ReadOnly = true;
            this.tb_xCommandPos.Size = new System.Drawing.Size(71, 21);
            this.tb_xCommandPos.TabIndex = 15;
            // 
            // tb_xDGain
            // 
            this.tb_xDGain.Location = new System.Drawing.Point(210, 20);
            this.tb_xDGain.Name = "tb_xDGain";
            this.tb_xDGain.ReadOnly = true;
            this.tb_xDGain.Size = new System.Drawing.Size(55, 21);
            this.tb_xDGain.TabIndex = 26;
            // 
            // tb_xIGain
            // 
            this.tb_xIGain.Location = new System.Drawing.Point(115, 20);
            this.tb_xIGain.Name = "tb_xIGain";
            this.tb_xIGain.ReadOnly = true;
            this.tb_xIGain.Size = new System.Drawing.Size(61, 21);
            this.tb_xIGain.TabIndex = 27;
            // 
            // tb_xPGain
            // 
            this.tb_xPGain.Location = new System.Drawing.Point(33, 20);
            this.tb_xPGain.Name = "tb_xPGain";
            this.tb_xPGain.ReadOnly = true;
            this.tb_xPGain.Size = new System.Drawing.Size(55, 21);
            this.tb_xPGain.TabIndex = 28;
            // 
            // gb_xGroup
            // 
            this.gb_xGroup.BackColor = System.Drawing.Color.Silver;
            this.gb_xGroup.Controls.Add(this.bt_xServoOn);
            this.gb_xGroup.Controls.Add(this.bt_xAlarmClr);
            this.gb_xGroup.Controls.Add(this.bt_xHome);
            this.gb_xGroup.Controls.Add(this.bt_xPosClr);
            this.gb_xGroup.Controls.Add(this.bt_xSstop);
            this.gb_xGroup.Controls.Add(this.bt_xEstop);
            this.gb_xGroup.Controls.Add(this.tb_xVel);
            this.gb_xGroup.Controls.Add(this.tb_xAcc);
            this.gb_xGroup.Controls.Add(this.tb_xDec);
            this.gb_xGroup.Controls.Add(this.tb_xCommandPos);
            this.gb_xGroup.Controls.Add(this.tb_xFeedPos);
            this.gb_xGroup.Controls.Add(this.tb_xFeedVel);
            this.gb_xGroup.Controls.Add(this.groupBox1);
            this.gb_xGroup.Controls.Add(this.groupBox2);
            this.gb_xGroup.Controls.Add(this.groupBox3);
            this.gb_xGroup.ForeColor = System.Drawing.Color.Black;
            this.gb_xGroup.Location = new System.Drawing.Point(869, 89);
            this.gb_xGroup.Name = "gb_xGroup";
            this.gb_xGroup.Size = new System.Drawing.Size(340, 300);
            this.gb_xGroup.TabIndex = 32;
            this.gb_xGroup.TabStop = false;
            this.gb_xGroup.Text = "X축";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 104);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[파라미터]";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Deceleration";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Acceleration";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Velocity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(28, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(197, 100);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[모니터링]";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(6, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 35;
            this.label4.Text = "Feedback Vel";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Feedback Pos";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Command Pos";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_xPGain);
            this.groupBox3.Controls.Add(this.tb_xDGain);
            this.groupBox3.Controls.Add(this.tb_xIGain);
            this.groupBox3.Location = new System.Drawing.Point(28, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(278, 56);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[모니터링 PID]";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label9.Location = new System.Drawing.Point(182, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 21);
            this.label9.TabIndex = 38;
            this.label9.Text = "D :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(93, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 21);
            this.label8.TabIndex = 37;
            this.label8.Text = "I :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 21);
            this.label7.TabIndex = 36;
            this.label7.Text = "P :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Silver;
            this.groupBox4.Controls.Add(this.bt_yServoOn);
            this.groupBox4.Controls.Add(this.bt_yAlarmClr);
            this.groupBox4.Controls.Add(this.bt_yHome);
            this.groupBox4.Controls.Add(this.bt_yPosClr);
            this.groupBox4.Controls.Add(this.bt_ySstop);
            this.groupBox4.Controls.Add(this.bt_yEstop);
            this.groupBox4.Controls.Add(this.tb_yVel);
            this.groupBox4.Controls.Add(this.tb_yAcc);
            this.groupBox4.Controls.Add(this.tb_yDec);
            this.groupBox4.Controls.Add(this.tb_yCommandPos);
            this.groupBox4.Controls.Add(this.tb_yFeedPos);
            this.groupBox4.Controls.Add(this.tb_yFeedVel);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.groupBox7);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(871, 398);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 300);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Y축";
            // 
            // bt_yServoOn
            // 
            this.bt_yServoOn.Location = new System.Drawing.Point(231, 41);
            this.bt_yServoOn.Name = "bt_yServoOn";
            this.bt_yServoOn.Size = new System.Drawing.Size(75, 23);
            this.bt_yServoOn.TabIndex = 0;
            this.bt_yServoOn.Text = "Servo On";
            this.bt_yServoOn.UseVisualStyleBackColor = true;
            this.bt_yServoOn.Click += new System.EventHandler(this.bt_yServoOn_Click);
            // 
            // bt_yAlarmClr
            // 
            this.bt_yAlarmClr.Location = new System.Drawing.Point(231, 68);
            this.bt_yAlarmClr.Name = "bt_yAlarmClr";
            this.bt_yAlarmClr.Size = new System.Drawing.Size(75, 23);
            this.bt_yAlarmClr.TabIndex = 1;
            this.bt_yAlarmClr.Text = "Alarm Clr";
            this.bt_yAlarmClr.UseVisualStyleBackColor = true;
            // 
            // bt_yHome
            // 
            this.bt_yHome.Location = new System.Drawing.Point(231, 95);
            this.bt_yHome.Name = "bt_yHome";
            this.bt_yHome.Size = new System.Drawing.Size(75, 23);
            this.bt_yHome.TabIndex = 2;
            this.bt_yHome.Text = "Home";
            this.bt_yHome.UseVisualStyleBackColor = true;
            this.bt_yHome.Click += new System.EventHandler(this.bt_yHome_Click);
            // 
            // bt_yPosClr
            // 
            this.bt_yPosClr.Location = new System.Drawing.Point(231, 144);
            this.bt_yPosClr.Name = "bt_yPosClr";
            this.bt_yPosClr.Size = new System.Drawing.Size(75, 23);
            this.bt_yPosClr.TabIndex = 3;
            this.bt_yPosClr.Text = "Pos Clr";
            this.bt_yPosClr.UseVisualStyleBackColor = true;
            // 
            // bt_ySstop
            // 
            this.bt_ySstop.Location = new System.Drawing.Point(231, 169);
            this.bt_ySstop.Name = "bt_ySstop";
            this.bt_ySstop.Size = new System.Drawing.Size(75, 23);
            this.bt_ySstop.TabIndex = 4;
            this.bt_ySstop.Text = "SSTOP";
            this.bt_ySstop.UseVisualStyleBackColor = true;
            // 
            // bt_yEstop
            // 
            this.bt_yEstop.Location = new System.Drawing.Point(231, 196);
            this.bt_yEstop.Name = "bt_yEstop";
            this.bt_yEstop.Size = new System.Drawing.Size(75, 23);
            this.bt_yEstop.TabIndex = 5;
            this.bt_yEstop.Text = "ESTOP";
            this.bt_yEstop.UseVisualStyleBackColor = true;
            // 
            // tb_yVel
            // 
            this.tb_yVel.Location = new System.Drawing.Point(142, 41);
            this.tb_yVel.Name = "tb_yVel";
            this.tb_yVel.Size = new System.Drawing.Size(71, 21);
            this.tb_yVel.TabIndex = 12;
            this.tb_yVel.Text = "200";
            this.tb_yVel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yVel_KeyPress);
            // 
            // tb_yAcc
            // 
            this.tb_yAcc.Location = new System.Drawing.Point(142, 68);
            this.tb_yAcc.Name = "tb_yAcc";
            this.tb_yAcc.Size = new System.Drawing.Size(71, 21);
            this.tb_yAcc.TabIndex = 13;
            this.tb_yAcc.Text = "200";
            this.tb_yAcc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yAcc_KeyPress);
            // 
            // tb_yDec
            // 
            this.tb_yDec.Location = new System.Drawing.Point(142, 97);
            this.tb_yDec.Name = "tb_yDec";
            this.tb_yDec.Size = new System.Drawing.Size(71, 21);
            this.tb_yDec.TabIndex = 14;
            this.tb_yDec.Text = "200";
            this.tb_yDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_yDec_KeyPress);
            // 
            // tb_yCommandPos
            // 
            this.tb_yCommandPos.Location = new System.Drawing.Point(142, 146);
            this.tb_yCommandPos.Name = "tb_yCommandPos";
            this.tb_yCommandPos.ReadOnly = true;
            this.tb_yCommandPos.Size = new System.Drawing.Size(71, 21);
            this.tb_yCommandPos.TabIndex = 15;
            // 
            // tb_yFeedPos
            // 
            this.tb_yFeedPos.Location = new System.Drawing.Point(142, 173);
            this.tb_yFeedPos.Name = "tb_yFeedPos";
            this.tb_yFeedPos.ReadOnly = true;
            this.tb_yFeedPos.Size = new System.Drawing.Size(71, 21);
            this.tb_yFeedPos.TabIndex = 16;
            // 
            // tb_yFeedVel
            // 
            this.tb_yFeedVel.Location = new System.Drawing.Point(142, 200);
            this.tb_yFeedVel.Name = "tb_yFeedVel";
            this.tb_yFeedVel.ReadOnly = true;
            this.tb_yFeedVel.Size = new System.Drawing.Size(71, 21);
            this.tb_yFeedVel.TabIndex = 17;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(28, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(197, 104);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "[파라미터]";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label10.Location = new System.Drawing.Point(6, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Deceleration";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label11.Location = new System.Drawing.Point(6, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "Acceleration";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label12.Location = new System.Drawing.Point(6, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 23);
            this.label12.TabIndex = 30;
            this.label12.Text = "Velocity";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(28, 131);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(197, 100);
            this.groupBox6.TabIndex = 33;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "[모니터링]";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 23);
            this.label13.TabIndex = 35;
            this.label13.Text = "Feedback Vel";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label14.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label14.Location = new System.Drawing.Point(6, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 23);
            this.label14.TabIndex = 34;
            this.label14.Text = "Feedback Pos";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label15.Location = new System.Drawing.Point(6, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 23);
            this.label15.TabIndex = 33;
            this.label15.Text = "Command Pos";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.tb_yPGain);
            this.groupBox7.Controls.Add(this.tb_yDGain);
            this.groupBox7.Controls.Add(this.tb_yIGain);
            this.groupBox7.Location = new System.Drawing.Point(28, 237);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(278, 56);
            this.groupBox7.TabIndex = 34;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "[모니터링 PID]";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label16.Location = new System.Drawing.Point(182, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 21);
            this.label16.TabIndex = 38;
            this.label16.Text = "D :";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label17.Location = new System.Drawing.Point(93, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 21);
            this.label17.TabIndex = 37;
            this.label17.Text = "I :";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label18.Location = new System.Drawing.Point(6, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 21);
            this.label18.TabIndex = 36;
            this.label18.Text = "P :";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_yPGain
            // 
            this.tb_yPGain.Location = new System.Drawing.Point(33, 20);
            this.tb_yPGain.Name = "tb_yPGain";
            this.tb_yPGain.ReadOnly = true;
            this.tb_yPGain.Size = new System.Drawing.Size(55, 21);
            this.tb_yPGain.TabIndex = 28;
            // 
            // tb_yDGain
            // 
            this.tb_yDGain.Location = new System.Drawing.Point(210, 20);
            this.tb_yDGain.Name = "tb_yDGain";
            this.tb_yDGain.ReadOnly = true;
            this.tb_yDGain.Size = new System.Drawing.Size(55, 21);
            this.tb_yDGain.TabIndex = 26;
            // 
            // tb_yIGain
            // 
            this.tb_yIGain.Location = new System.Drawing.Point(115, 20);
            this.tb_yIGain.Name = "tb_yIGain";
            this.tb_yIGain.ReadOnly = true;
            this.tb_yIGain.Size = new System.Drawing.Size(61, 21);
            this.tb_yIGain.TabIndex = 27;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.Color.Silver;
            this.groupBox8.Controls.Add(this.bt_Set_MoveNum);
            this.groupBox8.Controls.Add(this.tb_MoveNum);
            this.groupBox8.Location = new System.Drawing.Point(309, 87);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(200, 55);
            this.groupBox8.TabIndex = 33;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "이동 횟수";
            // 
            // bt_Set_MoveNum
            // 
            this.bt_Set_MoveNum.Location = new System.Drawing.Point(106, 23);
            this.bt_Set_MoveNum.Name = "bt_Set_MoveNum";
            this.bt_Set_MoveNum.Size = new System.Drawing.Size(81, 23);
            this.bt_Set_MoveNum.TabIndex = 35;
            this.bt_Set_MoveNum.Text = "Set";
            this.bt_Set_MoveNum.UseVisualStyleBackColor = true;
            this.bt_Set_MoveNum.Click += new System.EventHandler(this.bt_Set_MoveNum_Click);
            // 
            // tb_MoveNum
            // 
            this.tb_MoveNum.Location = new System.Drawing.Point(17, 23);
            this.tb_MoveNum.Name = "tb_MoveNum";
            this.tb_MoveNum.Size = new System.Drawing.Size(61, 21);
            this.tb_MoveNum.TabIndex = 39;
            this.tb_MoveNum.Text = "5";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(15, 18);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(175, 96);
            this.listView2.TabIndex = 36;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No";
            this.columnHeader4.Width = 33;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Pos(X,Y)";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "State";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.Color.Silver;
            this.groupBox10.Controls.Add(this.bt_listView_Reset);
            this.groupBox10.Controls.Add(this.listView2);
            this.groupBox10.Location = new System.Drawing.Point(309, 704);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(207, 120);
            this.groupBox10.TabIndex = 37;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Memory";
            // 
            // bt_listView_Reset
            // 
            this.bt_listView_Reset.Location = new System.Drawing.Point(69, 133);
            this.bt_listView_Reset.Name = "bt_listView_Reset";
            this.bt_listView_Reset.Size = new System.Drawing.Size(75, 23);
            this.bt_listView_Reset.TabIndex = 37;
            this.bt_listView_Reset.Text = "Reset";
            this.bt_listView_Reset.UseVisualStyleBackColor = true;
            this.bt_listView_Reset.Click += new System.EventHandler(this.bt_listView_Reset_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.BackColor = System.Drawing.Color.Silver;
            this.groupBox11.Controls.Add(this.button1);
            this.groupBox11.Location = new System.Drawing.Point(522, 704);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(687, 120);
            this.groupBox11.TabIndex = 38;
            this.groupBox11.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.Color.Silver;
            this.groupBox9.Controls.Add(this.rb_FeedLine);
            this.groupBox9.Controls.Add(this.rb_CP);
            this.groupBox9.Controls.Add(this.button2);
            this.groupBox9.Location = new System.Drawing.Point(515, 87);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 55);
            this.groupBox9.TabIndex = 39;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "MODE";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(69, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // rb_CP
            // 
            this.rb_CP.AutoSize = true;
            this.rb_CP.Location = new System.Drawing.Point(29, 24);
            this.rb_CP.Name = "rb_CP";
            this.rb_CP.Size = new System.Drawing.Size(40, 16);
            this.rb_CP.TabIndex = 38;
            this.rb_CP.TabStop = true;
            this.rb_CP.Text = "CP";
            this.rb_CP.UseVisualStyleBackColor = true;
            // 
            // rb_FeedLine
            // 
            this.rb_FeedLine.AutoSize = true;
            this.rb_FeedLine.Location = new System.Drawing.Point(76, 23);
            this.rb_FeedLine.Name = "rb_FeedLine";
            this.rb_FeedLine.Size = new System.Drawing.Size(75, 16);
            this.rb_FeedLine.TabIndex = 39;
            this.rb_FeedLine.TabStop = true;
            this.rb_FeedLine.Text = "FeedLine";
            this.rb_FeedLine.UseVisualStyleBackColor = true;
            // 
            // PTP_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1428, 855);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pl_stage);
            this.Controls.Add(this.gb_xGroup);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PTP_Form";
            this.Text = "PTP_Form";
            this.Load += new System.EventHandler(this.PTP_Form_Load);
            this.Shown += new System.EventHandler(this.PTP_Form_Shown);
            this.gb_xGroup.ResumeLayout(false);
            this.gb_xGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pl_stage;
        private System.Windows.Forms.Button bt_xAlarmClr;
        private System.Windows.Forms.Button bt_xHome;
        private System.Windows.Forms.Button bt_xPosClr;
        private System.Windows.Forms.Button bt_xSstop;
        private System.Windows.Forms.Button bt_xEstop;
        private System.Windows.Forms.TextBox tb_xVel;
        private System.Windows.Forms.TextBox tb_xAcc;
        private System.Windows.Forms.TextBox tb_xDec;
        private System.Windows.Forms.TextBox tb_xFeedVel;
        private System.Windows.Forms.TextBox tb_xFeedPos;
        private System.Windows.Forms.TextBox tb_xCommandPos;
        private System.Windows.Forms.GroupBox gb_xGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_yAlarmClr;
        private System.Windows.Forms.Button bt_yHome;
        private System.Windows.Forms.Button bt_yPosClr;
        private System.Windows.Forms.Button bt_ySstop;
        private System.Windows.Forms.Button bt_yEstop;
        private System.Windows.Forms.TextBox tb_yVel;
        private System.Windows.Forms.TextBox tb_yAcc;
        private System.Windows.Forms.TextBox tb_yDec;
        private System.Windows.Forms.TextBox tb_yCommandPos;
        private System.Windows.Forms.TextBox tb_yFeedPos;
        private System.Windows.Forms.TextBox tb_yFeedVel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox tb_xDGain;
        public System.Windows.Forms.TextBox tb_xIGain;
        public System.Windows.Forms.TextBox tb_xPGain;
        public System.Windows.Forms.TextBox tb_yPGain;
        public System.Windows.Forms.TextBox tb_yDGain;
        public System.Windows.Forms.TextBox tb_yIGain;
        public System.Windows.Forms.Button bt_xServoOn;
        public System.Windows.Forms.Button bt_yServoOn;
        private System.Windows.Forms.GroupBox groupBox8;
        public System.Windows.Forms.Button bt_Set_MoveNum;
        public System.Windows.Forms.TextBox tb_MoveNum;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button bt_listView_Reset;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rb_FeedLine;
        private System.Windows.Forms.RadioButton rb_CP;
    }
}