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
            this.send = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.send_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
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
            this.label3.Location = new System.Drawing.Point(209, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "송신";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(209, 175);
            this.send.Multiline = true;
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(562, 100);
            this.send.TabIndex = 12;
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
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(696, 281);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 23);
            this.send_btn.TabIndex = 15;
            this.send_btn.Text = "전송";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 334);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.send);
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
        private System.Windows.Forms.TextBox send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.Label label6;
    }
}

