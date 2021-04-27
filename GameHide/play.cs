using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GameHide
{
    public partial class play : Form
    {
        public play()
        {
            InitializeComponent();
        }

        private void play_Load(object sender, EventArgs e)
        {
            Button btn1 = CreateButton("1", "1");
            Button btn2 = CreateButton("2", "2");
            Button btn3 = CreateButton("3", "3");
            Button btn4 = CreateButton("4", "4");
            Button btn5 = CreateButton("5", "5");
            Button btn6 = CreateButton("6", "6");
            Button btn7 = CreateButton("7", "7");
            Button btn8 = CreateButton("8", "8");
            Button btn9 = CreateButton("9", "9");
            Button btn0 = CreateButton("0", "0");

            Button btnq = CreateButton("q", "Q");
            Button btnw = CreateButton("w", "W");
            Button btne = CreateButton("e", "E");
            Button btnr = CreateButton("r", "R");
            Button btnt = CreateButton("t", "T");
            Button btny = CreateButton("y", "Y");
            Button btnu = CreateButton("u", "U");
            Button btni = CreateButton("i", "I");
            Button btno = CreateButton("o", "O");
            Button btnp = CreateButton("p", "P");

            Button btna = CreateButton("a", "A");
            Button btns = CreateButton("s", "S");
            Button btnd = CreateButton("d", "D");
            Button btnf = CreateButton("f", "F");
            Button btng = CreateButton("g", "G");
            Button btnh = CreateButton("h", "H");
            Button btnj = CreateButton("j", "J");
            Button btnk = CreateButton("k", "K");
            Button btnl = CreateButton("l", "L");
            Button btn_Delete = CreateButton("delete", "←delete");

            Button btnz = CreateButton("z", "Z");
            Button btnx = CreateButton("x", "X");
            Button btnc = CreateButton("c", "C");
            Button btnv = CreateButton("v", "V");
            Button btnb = CreateButton("b", "B");
            Button btnn = CreateButton("n", "N");
            Button btnm = CreateButton("m", "M");
            Button btn_Enter = CreateButton("enter", "↲Enter");



            key.Controls.Add(btn1, 0, 0); 
            key.Controls.Add(btn2, 1, 0);
            key.Controls.Add(btn3, 2, 0);
            key.Controls.Add(btn4, 3, 0);
            key.Controls.Add(btn5, 4, 0);
            key.Controls.Add(btn6, 5, 0);
            key.Controls.Add(btn7, 6, 0);
            key.Controls.Add(btn8, 7, 0);
            key.Controls.Add(btn9, 8, 0);
            key.Controls.Add(btn0, 9, 0);

            key.Controls.Add(btnq, 0, 1);
            key.Controls.Add(btnw, 1, 1);
            key.Controls.Add(btne, 2, 1);
            key.Controls.Add(btnr, 3, 1);
            key.Controls.Add(btnt, 4, 1);
            key.Controls.Add(btny, 5, 1);
            key.Controls.Add(btnu, 6, 1);
            key.Controls.Add(btni, 7, 1);
            key.Controls.Add(btno, 8, 1);
            key.Controls.Add(btnp, 9, 1);

            key.Controls.Add(btna, 0, 2);
            key.Controls.Add(btns, 1, 2);
            key.Controls.Add(btnd, 2, 2);
            key.Controls.Add(btnf, 3, 2);
            key.Controls.Add(btng, 4, 2);
            key.Controls.Add(btnh, 5, 2);
            key.Controls.Add(btnj, 6, 2);
            key.Controls.Add(btnk, 7, 2);
            key.Controls.Add(btnl, 8, 2);
            key.Controls.Add(btn_Delete, 9, 2);

            key.Controls.Add(btnz, 1, 3);
            key.Controls.Add(btnx, 2, 3);
            key.Controls.Add(btnc, 3, 3);
            key.Controls.Add(btnv, 4, 3);
            key.Controls.Add(btnb, 5, 3);
            key.Controls.Add(btnn, 6, 3);
            key.Controls.Add(btnm, 7, 3);
            key.Controls.Add(btn_Enter, 8, 3);
        }

        public Button CreateButton(string name, string text)
        {
            Button btn = new Button();
            btn.Name = name;
            btn.Text = text;
            btn.Dock = DockStyle.Fill;
            btn.Click += btn_Click;  

            return btn;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name == "enter")
            {
                if (password.Text == "1")
                {
                    setting display = new setting();
                    display.Show();
                }
                else
                {
                    password.Text = "";
                }
            }
            else if (btn.Name == "delete")
            {
            }
            else
                password.Text += btn.Name;

            
        }
    }
}
