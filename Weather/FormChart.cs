using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class FormChart : Form
    {
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartTemperatura
        {
            get { return this.chart1; }
        }

        public System.Windows.Forms.DataVisualization.Charting.Chart ChartCisnienie
        {
            get { return this.chart2; }
        }

        public FormChart()
        {
            InitializeComponent();
            chart2.Series["Cisnienie"].BorderWidth = 5;
            chart2.ChartAreas[0].AxisY.Minimum = 950;
        }
    }
}
