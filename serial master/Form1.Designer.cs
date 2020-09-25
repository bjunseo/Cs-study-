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
            this.SuspendLayout();
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(29, 12);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(163, 23);
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
            this.baudrate.Location = new System.Drawing.Point(29, 41);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(163, 23);
            this.baudrate.TabIndex = 2;
            // 
            // Receive
            // 
            this.Receive.AcceptsReturn = true;
            this.Receive.Location = new System.Drawing.Point(209, 41);
            this.Receive.Multiline = true;
            this.Receive.Name = "Receive";
            this.Receive.ShortcutsEnabled = false;
            this.Receive.Size = new System.Drawing.Size(579, 100);
            this.Receive.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(29, 109);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 15);
            this.status.TabIndex = 7;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(29, 71);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "연결 하기";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Unconnect
            // 
            this.Unconnect.Location = new System.Drawing.Point(117, 71);
            this.Unconnect.Name = "Unconnect";
            this.Unconnect.Size = new System.Drawing.Size(75, 23);
            this.Unconnect.TabIndex = 9;
            this.Unconnect.Text = "연결 끊기";
            this.Unconnect.UseVisualStyleBackColor = true;
            this.Unconnect.Click += new System.EventHandler(this.Unconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Unconnect);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.status);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.baudrate);
            this.Controls.Add(this.PortList);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

