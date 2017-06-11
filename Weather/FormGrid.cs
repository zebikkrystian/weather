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
    public partial class FormGrid : Form
    {
        public FormGrid()
        {
            InitializeComponent();
        }

        private void FormGrid_Load(object sender, EventArgs e)
        {
            this.pogodaDniTableAdapter.Fill(this.databaseDataSet.PogodaDni);
            this.pogodaTableAdapter.Fill(this.databaseDataSet.Pogoda);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pogodaTableAdapter.Update(this.databaseDataSet.Pogoda);
            this.pogodaDniTableAdapter.Update(this.databaseDataSet.PogodaDni);
            
            MessageBox.Show("Zapisano zmiany w bazie","",MessageBoxButtons.OK);
        }
    }
}
