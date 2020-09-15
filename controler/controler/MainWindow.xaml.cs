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
using System.IO.Ports;

namespace controler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PortList.ItemsSource = SerialPort.GetPortNames();
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox com = sender as ComboBox;
            if(com != null)
            {
                ComboBoxItem PORT = com.SelectedItem as ComboBoxItem;
                if(PORT != null)
                {
                    string nowPORT = PORT.Content.ToString();
                }
            }
        }

        private void click_startBTN(object sender, RoutedEventArgs e)
        {
            /*if(!serialPort1.IsOpen)
            {

            }*/
        }
    }
}
