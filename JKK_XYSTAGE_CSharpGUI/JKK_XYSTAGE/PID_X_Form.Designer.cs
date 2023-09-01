
namespace JKK_XYSTAGE
{
    partial class PID_X_Form
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tb_X_Get_D = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_X_Get_I = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_X_Get_P = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.bt_Motor_On = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bt_Simul_ParaSet = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_xvel_ref = new System.Windows.Forms.TextBox();
            this.tb_xpos_ref = new System.Windows.Forms.TextBox();
            this.bt_Home = new System.Windows.Forms.Button();
            this.bt_Simulation = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_D_GainSet = new System.Windows.Forms.Button();
            this.bt_I_GainSet = new System.Windows.Forms.Button();
            this.bt_P_GainSet = new System.Windows.Forms.Button();
            this.tb_D_Gain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_I_Gain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_P_Gain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.X_Gain_Plot = new ScottPlot.FormsPlot();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_Gr_Start = new System.Windows.Forms.Button();
            this.bt_Gr_Stop = new System.Windows.Forms.Button();
            this.bt_Gr_Captue = new System.Windows.Forms.Button();
            this.bt_Gain_ReSet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(185, 514);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1100, 183);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PID";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tb_X_Get_D);
            this.groupBox7.Controls.Add(this.label6);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.tb_X_Get_I);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.tb_X_Get_P);
            this.groupBox7.Location = new System.Drawing.Point(899, 29);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(87, 124);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Previous Gain";
            // 
            // tb_X_Get_D
            // 
            this.tb_X_Get_D.Location = new System.Drawing.Point(31, 83);
            this.tb_X_Get_D.Name = "tb_X_Get_D";
            this.tb_X_Get_D.ReadOnly = true;
            this.tb_X_Get_D.Size = new System.Drawing.Size(42, 21);
            this.tb_X_Get_D.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "P :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "I :";
            // 
            // tb_X_Get_I
            // 
            this.tb_X_Get_I.Location = new System.Drawing.Point(31, 61);
            this.tb_X_Get_I.Name = "tb_X_Get_I";
            this.tb_X_Get_I.ReadOnly = true;
            this.tb_X_Get_I.Size = new System.Drawing.Size(42, 21);
            this.tb_X_Get_I.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "D :";
            // 
            // tb_X_Get_P
            // 
            this.tb_X_Get_P.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tb_X_Get_P.Location = new System.Drawing.Point(31, 38);
            this.tb_X_Get_P.Name = "tb_X_Get_P";
            this.tb_X_Get_P.ReadOnly = true;
            this.tb_X_Get_P.Size = new System.Drawing.Size(42, 21);
            this.tb_X_Get_P.TabIndex = 14;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.bt_Motor_On);
            this.groupBox6.Location = new System.Drawing.Point(18, 29);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(87, 55);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Servo On";
            // 
            // bt_Motor_On
            // 
            this.bt_Motor_On.Location = new System.Drawing.Point(8, 15);
            this.bt_Motor_On.Name = "bt_Motor_On";
            this.bt_Motor_On.Size = new System.Drawing.Size(65, 30);
            this.bt_Motor_On.TabIndex = 11;
            this.bt_Motor_On.Text = "Servo On";
            this.bt_Motor_On.UseVisualStyleBackColor = true;
            this.bt_Motor_On.Click += new System.EventHandler(this.bt_Motor_On_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.bt_Home);
            this.groupBox4.Controls.Add(this.bt_Simulation);
            this.groupBox4.Location = new System.Drawing.Point(592, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 124);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Move";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.bt_Simul_ParaSet);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.tb_xvel_ref);
            this.groupBox5.Controls.Add(this.tb_xpos_ref);
            this.groupBox5.Location = new System.Drawing.Point(99, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(190, 89);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Reference";
            // 
            // bt_Simul_ParaSet
            // 
            this.bt_Simul_ParaSet.Location = new System.Drawing.Point(151, 20);
            this.bt_Simul_ParaSet.Name = "bt_Simul_ParaSet";
            this.bt_Simul_ParaSet.Size = new System.Drawing.Size(33, 54);
            this.bt_Simul_ParaSet.TabIndex = 4;
            this.bt_Simul_ParaSet.Text = "Set";
            this.bt_Simul_ParaSet.UseVisualStyleBackColor = true;
            this.bt_Simul_ParaSet.Click += new System.EventHandler(this.bt_Simul_ParaSet_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "X_Vel_Ref :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "X_Pos_Ref :";
            // 
            // tb_xvel_ref
            // 
            this.tb_xvel_ref.Location = new System.Drawing.Point(85, 53);
            this.tb_xvel_ref.Name = "tb_xvel_ref";
            this.tb_xvel_ref.Size = new System.Drawing.Size(60, 21);
            this.tb_xvel_ref.TabIndex = 1;
            this.tb_xvel_ref.Text = "100";
            // 
            // tb_xpos_ref
            // 
            this.tb_xpos_ref.Location = new System.Drawing.Point(85, 20);
            this.tb_xpos_ref.Name = "tb_xpos_ref";
            this.tb_xpos_ref.Size = new System.Drawing.Size(60, 21);
            this.tb_xpos_ref.TabIndex = 0;
            this.tb_xpos_ref.Text = "100";
            // 
            // bt_Home
            // 
            this.bt_Home.Location = new System.Drawing.Point(6, 74);
            this.bt_Home.Name = "bt_Home";
            this.bt_Home.Size = new System.Drawing.Size(75, 29);
            this.bt_Home.TabIndex = 12;
            this.bt_Home.Text = "Home";
            this.bt_Home.UseVisualStyleBackColor = true;
            this.bt_Home.Click += new System.EventHandler(this.bt_Home_Click);
            // 
            // bt_Simulation
            // 
            this.bt_Simulation.Location = new System.Drawing.Point(6, 29);
            this.bt_Simulation.Name = "bt_Simulation";
            this.bt_Simulation.Size = new System.Drawing.Size(75, 29);
            this.bt_Simulation.TabIndex = 11;
            this.bt_Simulation.Text = "Simul";
            this.bt_Simulation.UseVisualStyleBackColor = true;
            this.bt_Simulation.Click += new System.EventHandler(this.bt_Simulation_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_D_GainSet);
            this.groupBox2.Controls.Add(this.bt_I_GainSet);
            this.groupBox2.Controls.Add(this.bt_P_GainSet);
            this.groupBox2.Controls.Add(this.tb_D_Gain);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_I_Gain);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_P_Gain);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(111, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 124);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GAIN";
            // 
            // bt_D_GainSet
            // 
            this.bt_D_GainSet.Location = new System.Drawing.Point(108, 89);
            this.bt_D_GainSet.Name = "bt_D_GainSet";
            this.bt_D_GainSet.Size = new System.Drawing.Size(69, 23);
            this.bt_D_GainSet.TabIndex = 9;
            this.bt_D_GainSet.Text = "Set";
            this.bt_D_GainSet.UseVisualStyleBackColor = true;
            this.bt_D_GainSet.Click += new System.EventHandler(this.bt_D_GainSet_Click);
            // 
            // bt_I_GainSet
            // 
            this.bt_I_GainSet.Location = new System.Drawing.Point(107, 54);
            this.bt_I_GainSet.Name = "bt_I_GainSet";
            this.bt_I_GainSet.Size = new System.Drawing.Size(69, 23);
            this.bt_I_GainSet.TabIndex = 8;
            this.bt_I_GainSet.Text = "Set";
            this.bt_I_GainSet.UseVisualStyleBackColor = true;
            this.bt_I_GainSet.Click += new System.EventHandler(this.bt_I_GainSet_Click);
            // 
            // bt_P_GainSet
            // 
            this.bt_P_GainSet.Location = new System.Drawing.Point(107, 22);
            this.bt_P_GainSet.Name = "bt_P_GainSet";
            this.bt_P_GainSet.Size = new System.Drawing.Size(69, 23);
            this.bt_P_GainSet.TabIndex = 7;
            this.bt_P_GainSet.Text = "Set";
            this.bt_P_GainSet.UseVisualStyleBackColor = true;
            this.bt_P_GainSet.Click += new System.EventHandler(this.bt_P_GainSet_Click);
            // 
            // tb_D_Gain
            // 
            this.tb_D_Gain.Location = new System.Drawing.Point(42, 91);
            this.tb_D_Gain.Name = "tb_D_Gain";
            this.tb_D_Gain.Size = new System.Drawing.Size(60, 21);
            this.tb_D_Gain.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "P :";
            // 
            // tb_I_Gain
            // 
            this.tb_I_Gain.Location = new System.Drawing.Point(42, 57);
            this.tb_I_Gain.Name = "tb_I_Gain";
            this.tb_I_Gain.Size = new System.Drawing.Size(60, 21);
            this.tb_I_Gain.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "I :";
            // 
            // tb_P_Gain
            // 
            this.tb_P_Gain.Location = new System.Drawing.Point(42, 22);
            this.tb_P_Gain.Name = "tb_P_Gain";
            this.tb_P_Gain.Size = new System.Drawing.Size(60, 21);
            this.tb_P_Gain.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "D :";
            // 
            // X_Gain_Plot
            // 
            this.X_Gain_Plot.Location = new System.Drawing.Point(138, 58);
            this.X_Gain_Plot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.X_Gain_Plot.Name = "X_Gain_Plot";
            this.X_Gain_Plot.Size = new System.Drawing.Size(1159, 451);
            this.X_Gain_Plot.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_Gr_Start
            // 
            this.bt_Gr_Start.Location = new System.Drawing.Point(6, 20);
            this.bt_Gr_Start.Name = "bt_Gr_Start";
            this.bt_Gr_Start.Size = new System.Drawing.Size(75, 62);
            this.bt_Gr_Start.TabIndex = 11;
            this.bt_Gr_Start.Text = "Graph Start";
            this.bt_Gr_Start.UseVisualStyleBackColor = true;
            this.bt_Gr_Start.Click += new System.EventHandler(this.bt_Gr_Start_Click);
            // 
            // bt_Gr_Stop
            // 
            this.bt_Gr_Stop.Location = new System.Drawing.Point(100, 20);
            this.bt_Gr_Stop.Name = "bt_Gr_Stop";
            this.bt_Gr_Stop.Size = new System.Drawing.Size(75, 62);
            this.bt_Gr_Stop.TabIndex = 12;
            this.bt_Gr_Stop.Text = "Graph Stop";
            this.bt_Gr_Stop.UseVisualStyleBackColor = true;
            this.bt_Gr_Stop.Click += new System.EventHandler(this.bt_Gr_Stop_Click);
            // 
            // bt_Gr_Captue
            // 
            this.bt_Gr_Captue.Location = new System.Drawing.Point(191, 20);
            this.bt_Gr_Captue.Name = "bt_Gr_Captue";
            this.bt_Gr_Captue.Size = new System.Drawing.Size(75, 62);
            this.bt_Gr_Captue.TabIndex = 13;
            this.bt_Gr_Captue.Text = "Graph Capture";
            this.bt_Gr_Captue.UseVisualStyleBackColor = true;
            // 
            // bt_Gain_ReSet
            // 
            this.bt_Gain_ReSet.Location = new System.Drawing.Point(6, 91);
            this.bt_Gain_ReSet.Name = "bt_Gain_ReSet";
            this.bt_Gain_ReSet.Size = new System.Drawing.Size(130, 26);
            this.bt_Gain_ReSet.TabIndex = 9;
            this.bt_Gain_ReSet.Text = "Graph Re-Draw";
            this.bt_Gain_ReSet.UseVisualStyleBackColor = true;
            this.bt_Gain_ReSet.Click += new System.EventHandler(this.bt_Gain_ReSet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_Gain_ReSet);
            this.groupBox3.Controls.Add(this.bt_Gr_Captue);
            this.groupBox3.Controls.Add(this.bt_Gr_Stop);
            this.groupBox3.Controls.Add(this.bt_Gr_Start);
            this.groupBox3.Location = new System.Drawing.Point(304, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 124);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GRAPH";
            // 
            // PID_X_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1434, 754);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.X_Gain_Plot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PID_X_Form";
            this.Text = "PID_X_Form";
            this.Load += new System.EventHandler(this.PID_X_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_D_GainSet;
        private System.Windows.Forms.Button bt_I_GainSet;
        private System.Windows.Forms.Button bt_P_GainSet;
        private System.Windows.Forms.TextBox tb_D_Gain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_I_Gain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_P_Gain;
        private System.Windows.Forms.Label label3;
        private ScottPlot.FormsPlot X_Gain_Plot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_xvel_ref;
        private System.Windows.Forms.TextBox tb_xpos_ref;
        private System.Windows.Forms.Button bt_Home;
        private System.Windows.Forms.Button bt_Simulation;
        private System.Windows.Forms.Button bt_Simul_ParaSet;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.Button bt_Motor_On;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox tb_X_Get_D;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_X_Get_I;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_X_Get_P;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_Gain_ReSet;
        private System.Windows.Forms.Button bt_Gr_Captue;
        private System.Windows.Forms.Button bt_Gr_Stop;
        private System.Windows.Forms.Button bt_Gr_Start;
    }
}