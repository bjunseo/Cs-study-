using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameHide
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ver = int.Parse(vertical.Text.ToString());
            int hoz = int.Parse(horizontal.Text.ToString());
            Display stream = new Display();
            stream.Vertical = ver;
            stream.Holizontal = hoz;
            stream.ShowDialog();
        }
    }
}
