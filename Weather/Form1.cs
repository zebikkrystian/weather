using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Model;
using System.Drawing;
using Db;

namespace Weather
{
    public partial class Form1 : Form
    {
        WeatherModel _model;

        /// <summary>
        /// Konstruktor okna
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            SetCombobox();
            GetWeather();
        }

        private void SetCombobox()
        {
            int currentIndex = comboBox1.SelectedIndex;
            var cities = Query.GetCities();
            comboBox1.Items.Clear();
            foreach (var city in cities)
            {
                comboBox1.Items.Add(city);
            }
            comboBox1.SelectedIndex = currentIndex < 0 ? 0 : currentIndex;
        }

        /// <summary>
        /// Pobiera pogodę
        /// </summary>
        private void GetWeather()
        {
            string city = "";
            if (comboBox1.SelectedItem != null)
            {
                city = comboBox1.SelectedItem.ToString();
            }

            var model = ClientSocket.StartClient(city);
            BindData(model);
        }

        /// <summary>
        /// Podpina dane do kontrolek
        /// </summary>
        /// <param name="model">Dane o pogodzie</param>
        private void BindData(WeatherModel model)
        {
            _model = model;
            labelMiasto.Text = model.Miasto + ", woj: " + model.Wojewodztwo;
            labelKraj.Text = model.Kraj;
            labelTemperatura.Text = model.Temperatura + " °C";
            labelOpis.Text = model.Opis;
            labelOpady.Text = model.Opady + " mm/m2";
            labelCisnienie.Text = model.Cisnienie + " hPa";
            labelWiatr.Text = model.Wiatr + " m/s";
            pictureBoxFoto.Image = (GetFoto(model.Foto));

            var d1 = model.Dni.ElementAtOrDefault(0);
            if (d1 != null)
            {
                labelD1Opis.Text = d1.Opis;
                labelD1Temperatura.Text = d1.Temperatura + " °C";
                labelD1Cisnienie.Text = d1.Cisnienie + " hPa";
                labelD1Dzien.Text = d1.Dzien;
                pictureBoxD1Foto.Image = (GetFoto(d1.Foto));
            }

            var d2 = model.Dni.ElementAtOrDefault(1);
            if (d2 != null)
            {
                labelD2Opis.Text = d2.Opis;
                labelD2Temperatura.Text = d2.Temperatura + " °C";
                labelD2Cisnienie.Text = d2.Cisnienie + " hPa";
                labelD2Dzien.Text = d2.Dzien;
                pictureBoxD2Foto.Image = (GetFoto(d2.Foto));
            }

            var d3 = model.Dni.ElementAtOrDefault(2);
            if (d3 != null)
            {
                labelD3Opis.Text = d3.Opis;
                labelD3Temperatura.Text = d3.Temperatura + " °C";
                labelD3Cisnienie.Text = d3.Cisnienie + " hPa";
                labelD3Dzien.Text = d3.Dzien;
                pictureBoxD3Foto.Image = (GetFoto(d3.Foto));
            }

            labelAktualizacja.Text = "Ostatnia aktualizacja: " + model.Aktualizacja.ToString("HH:mm:ss  dd.MM.yyyy");
        }

        /// <summary>
        /// Zwraca odpowiednią grafike.
        /// </summary>
        /// <param name="id">Id grafiki</param>
        /// <returns>Grafika</returns>
        private Bitmap GetFoto(int id)
        {
            switch (id)
            {
                case 1:
                    {
                        return Properties.Resources.id1;
                    }
                case 2:
                    {
                        return Properties.Resources.id2;
                    }
                case 3:
                    {
                        return Properties.Resources.id3;
                    }
                case 4:
                    {
                        return Properties.Resources.id4;
                    }
            }

            return null;
        }


        /// <summary>
        /// Obsługa zdarzenia kliknięcia w przycisk wyszukiwania
        /// </summary>
        /// <param name="sender">Źródło zdarzenia</param>
        /// <param name="e">Obiekt zdarzenia</param>
        private void pictureBoxFind_Click(object sender, EventArgs e)
        {
            GetWeather();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var grid = new FormGrid();
            grid.ShowDialog(this);

            SetCombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new FormChart();
            foreach (var day in _model.Dni)
            {
                form.Chart.Series["Temperatura"].Points.AddXY(day.Dzien, day.Temperatura);
            }
            form.ShowDialog();

        }
    }
}
