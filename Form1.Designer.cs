namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.SchedulerType_comboBox1 = new System.Windows.Forms.ComboBox();
            this.ArrivalTime_textBox1 = new System.Windows.Forms.TextBox();
            this.TimeNeeded_textBox2 = new System.Windows.Forms.TextBox();
            this.Priority_textBox3 = new System.Windows.Forms.TextBox();
            this.RRBurstTime_textBox4 = new System.Windows.Forms.TextBox();
            this.NumberTaskstextBox1 = new System.Windows.Forms.TextBox();
            this.StartSim_button1 = new System.Windows.Forms.Button();
            this.debug_label1 = new System.Windows.Forms.Label();
            this.Restart_button1 = new System.Windows.Forms.Button();
            this.Quantum_label1 = new System.Windows.Forms.Label();
            this.NumerTasks_label2 = new System.Windows.Forms.Label();
            this.ArrivalTime_label3 = new System.Windows.Forms.Label();
            this.TimeNeeded_label4 = new System.Windows.Forms.Label();
            this.Priority_label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.avgWaitingTime_label2 = new System.Windows.Forms.Label();
            this.arrivalTime_label2 = new System.Windows.Forms.Label();
            this.Burst_label3 = new System.Windows.Forms.Label();
            this.Priority_label4 = new System.Windows.Forms.Label();
            this.inst_label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // SchedulerType_comboBox1
            // 
            this.SchedulerType_comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.SchedulerType_comboBox1.FormattingEnabled = true;
            this.SchedulerType_comboBox1.Items.AddRange(new object[] {
            "FCFS",
            "SJF-Preempitive",
            "SJF-Nonpreempitive",
            "Priority-Preempitive",
            "Priority-Nonpreempitive",
            "RoundRobin"});
            this.SchedulerType_comboBox1.Location = new System.Drawing.Point(13, 11);
            this.SchedulerType_comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SchedulerType_comboBox1.Name = "SchedulerType_comboBox1";
            this.SchedulerType_comboBox1.Size = new System.Drawing.Size(155, 21);
            this.SchedulerType_comboBox1.TabIndex = 1;
            this.SchedulerType_comboBox1.Text = "Scheduler Type";
            this.SchedulerType_comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ArrivalTime_textBox1
            // 
            this.ArrivalTime_textBox1.Location = new System.Drawing.Point(163, 60);
            this.ArrivalTime_textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ArrivalTime_textBox1.Name = "ArrivalTime_textBox1";
            this.ArrivalTime_textBox1.Size = new System.Drawing.Size(41, 21);
            this.ArrivalTime_textBox1.TabIndex = 3;
            this.ArrivalTime_textBox1.Tag = "";
            this.ArrivalTime_textBox1.Text = "0";
            this.ArrivalTime_textBox1.TextChanged += new System.EventHandler(this.ArrivalTime_textBox1_TextChanged);
            this.ArrivalTime_textBox1.Enter += new System.EventHandler(this.ArrivalTime_textBox1_Enter);
            this.ArrivalTime_textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ArrivalTime_textBox1_KeyPress);
            // 
            // TimeNeeded_textBox2
            // 
            this.TimeNeeded_textBox2.Location = new System.Drawing.Point(163, 87);
            this.TimeNeeded_textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TimeNeeded_textBox2.Name = "TimeNeeded_textBox2";
            this.TimeNeeded_textBox2.Size = new System.Drawing.Size(41, 21);
            this.TimeNeeded_textBox2.TabIndex = 4;
            this.TimeNeeded_textBox2.Text = "0";
            this.TimeNeeded_textBox2.TextChanged += new System.EventHandler(this.TimeNeeded_textBox2_TextChanged);
            this.TimeNeeded_textBox2.Enter += new System.EventHandler(this.TimeNeeded_textBox2_Enter);
            this.TimeNeeded_textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeNeeded_textBox2_KeyPress);
            // 
            // Priority_textBox3
            // 
            this.Priority_textBox3.Location = new System.Drawing.Point(163, 116);
            this.Priority_textBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Priority_textBox3.Name = "Priority_textBox3";
            this.Priority_textBox3.Size = new System.Drawing.Size(41, 21);
            this.Priority_textBox3.TabIndex = 5;
            this.Priority_textBox3.Text = "0";
            this.Priority_textBox3.Visible = false;
            this.Priority_textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Priority_textBox3.Enter += new System.EventHandler(this.Priority_textBox3_Enter);
            this.Priority_textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Priority_textBox3_KeyPress);
            // 
            // RRBurstTime_textBox4
            // 
            this.RRBurstTime_textBox4.Location = new System.Drawing.Point(163, 33);
            this.RRBurstTime_textBox4.Name = "RRBurstTime_textBox4";
            this.RRBurstTime_textBox4.Size = new System.Drawing.Size(41, 21);
            this.RRBurstTime_textBox4.TabIndex = 6;
            this.RRBurstTime_textBox4.Text = "0";
            this.RRBurstTime_textBox4.Visible = false;
            this.RRBurstTime_textBox4.TextChanged += new System.EventHandler(this.RRBurstTime_textBox4_TextChanged);
            this.RRBurstTime_textBox4.Enter += new System.EventHandler(this.RRBurstTime_textBox4_Enter);
            this.RRBurstTime_textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RRBurstTime_textBox4_KeyPress);
            // 
            // NumberTaskstextBox1
            // 
            this.NumberTaskstextBox1.Location = new System.Drawing.Point(368, 11);
            this.NumberTaskstextBox1.Name = "NumberTaskstextBox1";
            this.NumberTaskstextBox1.Size = new System.Drawing.Size(43, 21);
            this.NumberTaskstextBox1.TabIndex = 7;
            this.NumberTaskstextBox1.Text = "0";
            this.NumberTaskstextBox1.TextChanged += new System.EventHandler(this.NumberTaskstextBox1_TextChanged);
            this.NumberTaskstextBox1.Enter += new System.EventHandler(this.NumberTaskstextBox1_Enter);
            this.NumberTaskstextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumberTaskstextBox1_KeyPress);
            // 
            // StartSim_button1
            // 
            this.StartSim_button1.BackColor = System.Drawing.Color.Transparent;
            this.StartSim_button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.StartSim_button1.Location = new System.Drawing.Point(130, 148);
            this.StartSim_button1.Name = "StartSim_button1";
            this.StartSim_button1.Size = new System.Drawing.Size(158, 22);
            this.StartSim_button1.TabIndex = 8;
            this.StartSim_button1.Text = "Start Simulation";
            this.StartSim_button1.UseVisualStyleBackColor = false;
            this.StartSim_button1.Click += new System.EventHandler(this.StartSim_button1_Click);
            // 
            // debug_label1
            // 
            this.debug_label1.AutoSize = true;
            this.debug_label1.Location = new System.Drawing.Point(12, 157);
            this.debug_label1.Name = "debug_label1";
            this.debug_label1.Size = new System.Drawing.Size(35, 13);
            this.debug_label1.TabIndex = 9;
            this.debug_label1.Text = "手さん";
            this.debug_label1.Visible = false;
            // 
            // Restart_button1
            // 
            this.Restart_button1.Location = new System.Drawing.Point(355, 316);
            this.Restart_button1.Name = "Restart_button1";
            this.Restart_button1.Size = new System.Drawing.Size(78, 37);
            this.Restart_button1.TabIndex = 10;
            this.Restart_button1.Text = "Restart";
            this.Restart_button1.UseVisualStyleBackColor = true;
            this.Restart_button1.TextChanged += new System.EventHandler(this.Restart);
            this.Restart_button1.Click += new System.EventHandler(this.Restart_button1_Click);
            // 
            // Quantum_label1
            // 
            this.Quantum_label1.AutoSize = true;
            this.Quantum_label1.Location = new System.Drawing.Point(12, 36);
            this.Quantum_label1.Name = "Quantum_label1";
            this.Quantum_label1.Size = new System.Drawing.Size(85, 13);
            this.Quantum_label1.TabIndex = 11;
            this.Quantum_label1.Text = "RR Quantum";
            this.Quantum_label1.Visible = false;
            // 
            // NumerTasks_label2
            // 
            this.NumerTasks_label2.AutoSize = true;
            this.NumerTasks_label2.Location = new System.Drawing.Point(217, 14);
            this.NumerTasks_label2.Name = "NumerTasks_label2";
            this.NumerTasks_label2.Size = new System.Drawing.Size(145, 13);
            this.NumerTasks_label2.TabIndex = 12;
            this.NumerTasks_label2.Text = "Number of Processes";
            // 
            // ArrivalTime_label3
            // 
            this.ArrivalTime_label3.AutoSize = true;
            this.ArrivalTime_label3.Location = new System.Drawing.Point(10, 63);
            this.ArrivalTime_label3.Name = "ArrivalTime_label3";
            this.ArrivalTime_label3.Size = new System.Drawing.Size(143, 13);
            this.ArrivalTime_label3.TabIndex = 13;
            this.ArrivalTime_label3.Text = "Process Arrival Time";
            // 
            // TimeNeeded_label4
            // 
            this.TimeNeeded_label4.AutoSize = true;
            this.TimeNeeded_label4.Location = new System.Drawing.Point(6, 90);
            this.TimeNeeded_label4.Name = "TimeNeeded_label4";
            this.TimeNeeded_label4.Size = new System.Drawing.Size(147, 13);
            this.TimeNeeded_label4.TabIndex = 14;
            this.TimeNeeded_label4.Text = "Process Needed Time";
            // 
            // Priority_label5
            // 
            this.Priority_label5.AutoSize = true;
            this.Priority_label5.Location = new System.Drawing.Point(12, 119);
            this.Priority_label5.Name = "Priority_label5";
            this.Priority_label5.Size = new System.Drawing.Size(111, 13);
            this.Priority_label5.TabIndex = 15;
            this.Priority_label5.Text = "Process Priority";
            this.Priority_label5.Visible = false;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Location = new System.Drawing.Point(2, 175);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(431, 135);
            this.chart1.TabIndex = 17;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Average Waiting Time :";
            this.label1.Visible = false;
            // 
            // avgWaitingTime_label2
            // 
            this.avgWaitingTime_label2.AutoSize = true;
            this.avgWaitingTime_label2.Location = new System.Drawing.Point(174, 322);
            this.avgWaitingTime_label2.Name = "avgWaitingTime_label2";
            this.avgWaitingTime_label2.Size = new System.Drawing.Size(15, 13);
            this.avgWaitingTime_label2.TabIndex = 19;
            this.avgWaitingTime_label2.Text = "0";
            this.avgWaitingTime_label2.Visible = false;
            // 
            // arrivalTime_label2
            // 
            this.arrivalTime_label2.AutoSize = true;
            this.arrivalTime_label2.Location = new System.Drawing.Point(244, 40);
            this.arrivalTime_label2.Name = "arrivalTime_label2";
            this.arrivalTime_label2.Size = new System.Drawing.Size(36, 13);
            this.arrivalTime_label2.TabIndex = 20;
            this.arrivalTime_label2.Text = "ArrT";
            this.arrivalTime_label2.Visible = false;
            // 
            // Burst_label3
            // 
            this.Burst_label3.AutoSize = true;
            this.Burst_label3.Location = new System.Drawing.Point(307, 40);
            this.Burst_label3.Name = "Burst_label3";
            this.Burst_label3.Size = new System.Drawing.Size(41, 13);
            this.Burst_label3.TabIndex = 21;
            this.Burst_label3.Text = "Burst";
            this.Burst_label3.Visible = false;
            // 
            // Priority_label4
            // 
            this.Priority_label4.AutoSize = true;
            this.Priority_label4.Location = new System.Drawing.Point(368, 40);
            this.Priority_label4.Name = "Priority_label4";
            this.Priority_label4.Size = new System.Drawing.Size(56, 13);
            this.Priority_label4.TabIndex = 22;
            this.Priority_label4.Text = "Priority";
            this.Priority_label4.Visible = false;
            // 
            // inst_label2
            // 
            this.inst_label2.AutoSize = true;
            this.inst_label2.BackColor = System.Drawing.Color.RosyBrown;
            this.inst_label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.inst_label2.Location = new System.Drawing.Point(82, 206);
            this.inst_label2.Name = "inst_label2";
            this.inst_label2.Size = new System.Drawing.Size(266, 65);
            this.inst_label2.TabIndex = 23;
            this.inst_label2.Text = "Instructions:\r\n-Type a value in textbox \r\nand press ENTER each time.\r\n- When fini" +
    "shed, press Start Simulation.\r\n\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(435, 357);
            this.Controls.Add(this.inst_label2);
            this.Controls.Add(this.Priority_label4);
            this.Controls.Add(this.Burst_label3);
            this.Controls.Add(this.arrivalTime_label2);
            this.Controls.Add(this.avgWaitingTime_label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Priority_label5);
            this.Controls.Add(this.TimeNeeded_label4);
            this.Controls.Add(this.ArrivalTime_label3);
            this.Controls.Add(this.NumerTasks_label2);
            this.Controls.Add(this.Quantum_label1);
            this.Controls.Add(this.Restart_button1);
            this.Controls.Add(this.debug_label1);
            this.Controls.Add(this.StartSim_button1);
            this.Controls.Add(this.NumberTaskstextBox1);
            this.Controls.Add(this.RRBurstTime_textBox4);
            this.Controls.Add(this.Priority_textBox3);
            this.Controls.Add(this.TimeNeeded_textBox2);
            this.Controls.Add(this.ArrivalTime_textBox1);
            this.Controls.Add(this.SchedulerType_comboBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "CPU Scheduler";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ArrivalTime_textBox1;
        private System.Windows.Forms.TextBox TimeNeeded_textBox2;
        private System.Windows.Forms.TextBox Priority_textBox3;
        private System.Windows.Forms.TextBox RRBurstTime_textBox4;
        private System.Windows.Forms.TextBox NumberTaskstextBox1;
        private System.Windows.Forms.Button StartSim_button1;
        private System.Windows.Forms.Label debug_label1;
        private System.Windows.Forms.Button Restart_button1;
        private System.Windows.Forms.Label Quantum_label1;
        private System.Windows.Forms.Label NumerTasks_label2;
        private System.Windows.Forms.Label ArrivalTime_label3;
        private System.Windows.Forms.Label TimeNeeded_label4;
        private System.Windows.Forms.Label Priority_label5;
        private System.Windows.Forms.ComboBox SchedulerType_comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label avgWaitingTime_label2;
        private System.Windows.Forms.Label arrivalTime_label2;
        private System.Windows.Forms.Label Burst_label3;
        private System.Windows.Forms.Label Priority_label4;
        private System.Windows.Forms.Label inst_label2;

    }
}

