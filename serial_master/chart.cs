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
        public chart()
        {
            InitializeComponent();
        }

        private void chart_Load(object sender, EventArgs e)
        {
            //timer1.Tick += timer1_Tick;
            //timer1.Interval = 2000;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].MarkerSize = 20;

            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 5;
            chart1.Series[0].Points.AddXY(1, 1);
            chart1.Series[0].Points.AddXY(2, 2);
            chart1.Series[0].Points.AddXY(3, 3);
            chart1.Series[0].Points.AddXY(4, 4);

        }

        /*
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        */
    }
}
