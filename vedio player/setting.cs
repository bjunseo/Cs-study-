using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace vedio_player
{
    public partial class setting : Form
    {
        public setting()
        {
            InitializeComponent();
            this.FormClosed += setting_Close;
        }

        private void setting_Load(object sender, EventArgs e)
        {
            
        }

        private void setting_Close(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ver = int.Parse(vertical.Text.ToString());
            int hoz = int.Parse(horizontal.Text.ToString());
            string F = File.Text.ToString();
            display stream = new display();
            stream.Vertical = ver;
            stream.Holizontal = hoz;
            stream.FIle = F;
            this.Close();
        }

       
    }
}
