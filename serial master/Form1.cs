using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_master
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        public Form1()
        {
            InitializeComponent();
            string[] Portnom = SerialPort.GetPortNames();

            foreach (string portnum in Portnom)
            {
                PortList.Items.Add(portnum);
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            string item;
            string[] _baudrate;
            _serialPort = new SerialPort();
            if (_serialPort.IsOpen == false)
            {
                _serialPort.PortName = PortList.SelectedItem.ToString();
                item = baudrate.SelectedItem.ToString();
                _baudrate = item.Split(": ");
                _serialPort.BaudRate = int.Parse(_baudrate[1]);
                _serialPort.DataBits = (int)8;
                _serialPort.Parity = Parity.None;
                _serialPort.StopBits = StopBits.One;
                _serialPort.ReadTimeout = (int)500;
                _serialPort.WriteTimeout = (int)500;
                _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

                _serialPort.Open();

                status.Text = _serialPort.PortName + "연결되었습니다.";
            }
            else
                status.Text = _serialPort.PortName + "연결되어 있습니다.";
        }

        private void Unconnect_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen == true)
            {
                _serialPort.Close();
                status.Text = _serialPort.PortName + "해제되었습니다.";
            }
            else
                status.Text = _serialPort.PortName + "해제되어 있습니다";
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
            //invoke
        }
        private void MySerialReceived(object s, EventArgs e)
        {
            string ReceiveData = _serialPort.ReadExisting();
            Receive.Text = string.Format("{0:X2}", ReceiveData);
        }
    }
}
