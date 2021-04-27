namespace serial_master
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortList = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.Receive = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Unconnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.send1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.send2 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.send3 = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn4 = new System.Windows.Forms.Button();
            this.send4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(85, 51);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(103, 23);
            this.PortList.TabIndex = 1;
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400",
            "250000"});
            this.baudrate.Location = new System.Drawing.Point(85, 80);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(103, 23);
            this.baudrate.TabIndex = 2;
            // 
            // Receive
            // 
            this.Receive.AcceptsReturn = true;
            this.Receive.AllowDrop = true;
            this.Receive.Location = new System.Drawing.Point(209, 33);
            this.Receive.Multiline = true;
            this.Receive.Name = "Receive";
            this.Receive.ShortcutsEnabled = false;
            this.Receive.Size = new System.Drawing.Size(562, 100);
            this.Receive.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(25, 148);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            this.status.TabIndex = 7;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(25, 110);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "연결 하기";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Unconnect
            // 
            this.Unconnect.Location = new System.Drawing.Point(113, 110);
            this.Unconnect.Name = "Unconnect";
            this.Unconnect.Size = new System.Drawing.Size(75, 23);
            this.Unconnect.TabIndex = 9;
            this.Unconnect.Text = "연결 끊기";
            this.Unconnect.UseVisualStyleBackColor = true;
            this.Unconnect.Click += new System.EventHandler(this.Unconnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "수신";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "수신";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "송신";
            // 
            // send1
            // 
            this.send1.Location = new System.Drawing.Point(241, 175);
            this.send1.Name = "send1";
            this.send1.Size = new System.Drawing.Size(444, 23);
            this.send1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "baudrate";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(696, 175);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 15;
            this.btn1.Text = "전송";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(25, 15);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Port Master";
            // 
            // chart
            // 
            this.chart.Location = new System.Drawing.Point(25, 144);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(163, 23);
            this.chart.TabIndex = 17;
            this.chart.Text = "플로우 차트";
            this.chart.UseVisualStyleBackColor = true;
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "1 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(209, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "2 :";
            // 
            // send2
            // 
            this.send2.Location = new System.Drawing.Point(241, 215);
            this.send2.Name = "send2";
            this.send2.Size = new System.Drawing.Size(444, 23);
            this.send2.TabIndex = 20;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(696, 214);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 21;
            this.btn2.Text = "전송";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(209, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "3 :";
            // 
            // send3
            // 
            this.send3.Location = new System.Drawing.Point(241, 254);
            this.send3.Name = "send3";
            this.send3.Size = new System.Drawing.Size(444, 23);
            this.send3.TabIndex = 23;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(696, 253);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 24;
            this.btn3.Text = "전송";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "4 :";
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(696, 292);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 26;
            this.btn4.Text = "전송";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // send4
            // 
            this.send4.Location = new System.Drawing.Point(240, 293);
            this.send4.Name = "send4";
            this.send4.Size = new System.Drawing.Size(444, 23);
            this.send4.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.send4);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.send3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.send2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.send1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Unconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.baudrate);
            this.Controls.Add(this.PortList);
            this.Name = "Form1";
            this.Text = "port master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.TextBox Receive;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Unconnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox send1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button chart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox send2;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox send3;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.TextBox send4;
    }
}

