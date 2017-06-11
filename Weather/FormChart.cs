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
        public System.Windows.Forms.DataVisualization.Charting.Chart Chart
        {
            get { return this.chart1; }
        }

        public FormChart()
        {
            InitializeComponent();
        }
    }
}
