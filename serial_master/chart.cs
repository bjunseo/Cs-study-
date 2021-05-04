using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace serial_master
{
    public partial class chart : Form
    {
        double x = 0;
        public chart()
        {
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e)
        {
            timer1.Tick += timer1_Tick;
            timer1.Interval = 1000;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].MarkerSize = 20;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(x, x);

            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = x;

            x += 1;
        }

        private void start_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
