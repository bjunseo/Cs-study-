using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameHide
{
    public partial class Display : Form
    {
        private int Form2_value;
        public int Vertical
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }
        }

        public int Holizontal
        {
            get { return this.Form2_value; }
            set { this.Form2_value = value; }
        }
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            a.Text = Vertical.ToString();
            b.Text = Holizontal.ToString();
        }
    }
}
