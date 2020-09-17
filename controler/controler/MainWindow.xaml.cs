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
using System.IO;

namespace controler
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort _serialPort;

        public MainWindow()
        {
            InitializeComponent();
            string[] Portnom = SerialPort.GetPortNames();

            foreach (string portnum in Portnom)
            {
                PortList.Items.Add(portnum);
            }
        }

        private void open_btn(object sender, RoutedEventArgs e)
        {
            test.Text = baudrate.SelectedItem.ToString() + PortList.SelectedItem.ToString();
            string item;
            string[] _baudrate;
            _serialPort = new SerialPort();
            if(_serialPort.IsOpen == false)
            {
                _serialPort.PortName = PortList.SelectedItem.ToString();
                item = baudrate.SelectedItem.ToString();
                _baudrate = item.Split(":");
                _serialPort.BaudRate = int.Parse(_baudrate[1]);
                _serialPort.DataBits = (int)8;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.ReadTimeout = (int)500;
                _serialPort.WriteTimeout = (int)500;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

                _serialPort.Open();

                status.Text = "연결되었습니다.";
            }
            else
                status.Text = "연결되어 있습니다.";
        }
        private void close_btn(object sender, RoutedEventArgs e)
        {
            if (_serialPort.IsOpen == true)
            {
                _serialPort.Close();
                status.Text = "해제되었습니다.";
            }
            else
                status.Text = "해제외어 있습니다"; 
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }

        private void MySerialReceived(object s, EventArgs e)
        {
            string ReceivedData = _serialPort.ReadLine();
            receive.Text = receive.Text + string.Format("{0:x2}", ReceivedData);
        }

       
    }
}
