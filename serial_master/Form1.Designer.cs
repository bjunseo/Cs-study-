
namespace serial_master
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
            this.label1 = new System.Windows.Forms.Label();
            this.PortList = new System.Windows.Forms.ComboBox();
            this.baudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.unconnect = new System.Windows.Forms.Button();
            this.Receive = new System.Windows.Forms.TextBox();
            this.send1 = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.Label();
            this.send2 = new System.Windows.Forms.TextBox();
            this.send3 = new System.Windows.Forms.TextBox();
            this.send4 = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.next_page = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Master";
            // 
            // PortList
            // 
            this.PortList.FormattingEnabled = true;
            this.PortList.Location = new System.Drawing.Point(87, 69);
            this.PortList.Name = "PortList";
            this.PortList.Size = new System.Drawing.Size(103, 20);
            this.PortList.TabIndex = 1;
            // 
            // baudrate
            // 
            this.baudrate.FormattingEnabled = true;
            this.baudrate.Items.AddRange(new object[] {
            "9600 ",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200"});
            this.baudrate.Location = new System.Drawing.Point(87, 105);
            this.baudrate.Name = "baudrate";
            this.baudrate.Size = new System.Drawing.Size(103, 20);
            this.baudrate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(27, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "port :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8F);
            this.label3.Location = new System.Drawing.Point(21, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 11);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baudrate :";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(472, 32);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "보내기";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.send_Click);
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(31, 144);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 6;
            this.connect.Text = "연결하기";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // unconnect
            // 
            this.unconnect.Location = new System.Drawing.Point(113, 144);
            this.unconnect.Name = "unconnect";
            this.unconnect.Size = new System.Drawing.Size(75, 23);
            this.unconnect.TabIndex = 7;
            this.unconnect.Text = "연결끊기";
            this.unconnect.UseVisualStyleBackColor = true;
            this.unconnect.Click += new System.EventHandler(this.unconnect_Click);
            // 
            // Receive
            // 
            this.Receive.Location = new System.Drawing.Point(12, 22);
            this.Receive.Multiline = true;
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(535, 147);
            this.Receive.TabIndex = 8;
            // 
            // send1
            // 
            this.send1.Location = new System.Drawing.Point(16, 34);
            this.send1.Name = "send1";
            this.send1.Size = new System.Drawing.Size(438, 21);
            this.send1.TabIndex = 9;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(472, 174);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(31, 186);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(0, 12);
            this.status.TabIndex = 11;
            // 
            // send2
            // 
            this.send2.Location = new System.Drawing.Point(16, 85);
            this.send2.Name = "send2";
            this.send2.Size = new System.Drawing.Size(438, 21);
            this.send2.TabIndex = 12;
            // 
            // send3
            // 
            this.send3.Location = new System.Drawing.Point(16, 135);
            this.send3.Name = "send3";
            this.send3.Size = new System.Drawing.Size(438, 21);
            this.send3.TabIndex = 13;
            // 
            // send4
            // 
            this.send4.Location = new System.Drawing.Point(16, 190);
            this.send4.Name = "send4";
            this.send4.Size = new System.Drawing.Size(438, 21);
            this.send4.TabIndex = 14;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(472, 83);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 15;
            this.btn2.Text = "보내기";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.send_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(472, 133);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 16;
            this.btn3.Text = "보내기";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.send_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(472, 188);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 17;
            this.btn4.Text = "보내기";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.send1);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.send2);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.send3);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.send4);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(211, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(567, 223);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Receive);
            this.groupBox2.Controls.Add(this.clear);
            this.groupBox2.Location = new System.Drawing.Point(211, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 209);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Receive";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // next_page
            // 
            this.next_page.Location = new System.Drawing.Point(31, 175);
            this.next_page.Name = "next_page";
            this.next_page.Size = new System.Drawing.Size(157, 23);
            this.next_page.TabIndex = 21;
            this.next_page.Text = "차트보기";
            this.next_page.UseVisualStyleBackColor = true;
            this.next_page.Click += new System.EventHandler(this.next_page_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.next_page);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.status);
            this.Controls.Add(this.unconnect);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baudrate);
            this.Controls.Add(this.PortList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox PortList;
        private System.Windows.Forms.ComboBox baudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button unconnect;
        private System.Windows.Forms.TextBox Receive;
        private System.Windows.Forms.TextBox send1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.TextBox send2;
        private System.Windows.Forms.TextBox send3;
        private System.Windows.Forms.TextBox send4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button next_page;
    }
}

