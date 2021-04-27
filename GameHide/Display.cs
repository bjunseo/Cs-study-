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
        private int Ver;
        private int Hol;
        public int Vertical
        {
            get { return this.Ver; }
            set { this.Ver = value; }
        }

        public int Holizontal
        {
            get { return this.Hol; }
            set { this.Hol = value; }
        }
        public Display()
        {
            InitializeComponent();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            
        }
    }
}
