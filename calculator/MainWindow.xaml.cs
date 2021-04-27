using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 0;
        int[] num1 = new int[10];

        public bool btnState { get; private set; }
        public double saveValue { get; private set; }

        private string Operator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            string num = btn.Content.ToString();
            if (Retext.Text == "0" || btnState == true)
            {
                Retext.Text = num;
                btnState = false;
            }
            else
                Retext.Text = Retext.Text + num;
        }

        private void btnOp_click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;

            saveValue = double.Parse(Retext.Text);
            Operator = btn.Content.ToString();
            btnState = true;   
        }

        private void btnPoint_click(object sender, RoutedEventArgs e)
        {
            if (Retext.Text.Contains(".") == false)
                Retext.Text = Retext.Text + ".";
        }

        private void Equal_click(object sender, RoutedEventArgs e)
        {
            if (Operator == "+")
                Retext.Text = (saveValue + double.Parse(Retext.Text)).ToString();
            else if (Operator == "-")
                Retext.Text = (saveValue - double.Parse(Retext.Text)).ToString();
            else if (Operator == "×")
                Retext.Text = (saveValue * double.Parse(Retext.Text)).ToString();
            else if (Operator == "÷")
                Retext.Text = (saveValue / double.Parse(Retext.Text)).ToString();
            else if (Operator == "^")
            {
                double j = double.Parse(Retext.Text);
                double square = 1;
                for (int i = 1; i <= j; i++)
                {
                    square = square * saveValue;
                }
                Retext.Text = square.ToString();
            }
        }
        private void reset_click(object sender, RoutedEventArgs e)
        {
            Retext.Text = "0";
            saveValue = 0;
        }

        private void btnFac_click(object sender, RoutedEventArgs e)
        {
            double j = double.Parse(Retext.Text);
            double factorial = 1;
            for(int i = 1; i <= j; i++)
            {
                factorial = factorial * i;
            }
            Retext.Text = factorial.ToString();
        }

        private void btnNext_click(object sender, EventArgs e)
        {
            key k = new key();
            k.Show();
        }
    }
}