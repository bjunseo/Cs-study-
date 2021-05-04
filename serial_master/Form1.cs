using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace serial_master
{
    public partial class Form1 : Form
    {
        private SerialPort _serialPort;

        int x;
        int y;
        int a;
        public Form1()
        {
            InitializeComponent();
            string[] Portnom = SerialPort.GetPortNames();

            foreach (string portnum in Portnom)
            {
                PortList.Items.Add(portnum);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].MarkerSize = 20;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(a, x);

            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = a;

            a += 1;
        }

        private void send_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.ToString() == "btn1") _serialPort.Write(send1.Text.ToString());
            else if (btn.Name.ToString() == "btn2") _serialPort.Write(send2.Text.ToString());
            else if (btn.Name.ToString() == "btn3") _serialPort.Write(send3.Text.ToString());
            else if (btn.Name.ToString() == "btn4") _serialPort.Write(send4.Text.ToString());
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort = new SerialPort();
                if (_serialPort.IsOpen == false)
                {
                    _serialPort.PortName = PortList.SelectedItem.ToString();
                    _serialPort.BaudRate = int.Parse(baudrate.SelectedItem.ToString());
                    _serialPort.DataBits = (int)8;
                    _serialPort.Parity = Parity.None;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.ReadTimeout = (int)500;
                    _serialPort.WriteTimeout = (int)500;
                    _serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);

                    _serialPort.Open();

                    status.Text = _serialPort.PortName + "연결되었습니다.";

                    timer1.Start();
                }
                else
                    status.Text = _serialPort.PortName + "연결되어 있습니다.";

            }
            catch (NullReferenceException ex)
            {

            }
        }

        private void unconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (_serialPort.IsOpen == true)
                {
                    _serialPort.Close();
                    status.Text = _serialPort.PortName + "해제되었습니다.";
                    Receive.Text = " ";
                    timer1.Stop();
                }
                else
                    status.Text = _serialPort.PortName + "해제되어 있습니다";
            }
            catch (NullReferenceException ex)
            {
                
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Receive.Text = "";     
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived));
            //invoke
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void next_page_Click(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => {
                nextpage();
            }));
        }

        private void nextpage()
        {
            chart Chart = new chart();
            Chart.Show();
        }

        private void MySerialReceived(object s, EventArgs e)
        {
            string ReceiveData = _serialPort.ReadLine().ToString();
            Receive.Text = ReceiveData;
            
            string[] a =  ReceiveData.Split(':');
            string[] b = a[1].Split(' ');
            x = int.Parse(b[0]);
            y = int.Parse(a[2]) / 10;
            /*
            Invoke(new Action(() => { pic(); })); ;
            */
        }

        private void pic()
        {
            /*
            panel1.Left = x;
            panel1.Top = y;
            */
        }
    }
}
