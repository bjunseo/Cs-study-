﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO.Ports;

namespace serial_master
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;
        int count, count2;
        public Form1()
        {
            InitializeComponent();
            string[] Portnom = SerialPort.GetPortNames();

            foreach (string portnum in Portnom)
            {
                PortList.Items.Add(portnum);
            }

            Receive.SelectionStart = Receive.Text.Length;
            Receive.ScrollToCaret();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            _serialPort = new SerialPort();
            if (_serialPort.IsOpen == false)
            { 
                try
                {
                    _serialPort.PortName = PortList.SelectedItem.ToString();
                    _serialPort.BaudRate = int.Parse(baudrate.SelectedItem.ToString());
                    _serialPort.DataBits = (int)8;
                    _serialPort.Parity = Parity.None;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.ReadTimeout = (int)500;
                    _serialPort.WriteTimeout = (int)500;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("port not connect","error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }

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
                Receive.Text = " ";
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
            string ReceiveData = _serialPort.ReadChar().ToString();
            Receive.Text = ReceiveData;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.ToString() == "btn1")  _serialPort.Write(send1.Text.ToString());
            else if (btn.Name.ToString() == "btn2") _serialPort.Write(send2.Text.ToString());
            else if (btn.Name.ToString() == "btn3") _serialPort.Write(send3.Text.ToString());
            else if (btn.Name.ToString() == "btn4") _serialPort.Write(send4.Text.ToString());
        }

        private void chart_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();
            chart.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}