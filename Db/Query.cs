using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db
{
    public class Query
    {
        public static string GetWeather(string city)
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Db.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            connection.Open();
            string query = string.Format("Select Miasto, Kraj, Wojewodztwo, Temperatura, Foto, Opis, Opady, Cisnienie, Wiatr, Id from dbo.Pogoda where Miasto = '{0}'", city.Replace("EOF",""));
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            var model = new WeatherModel { Dni = new List<WeatherNextDayModel>() };
            while (reader.Read())
            {
                model.Miasto = reader[0].ToString();
                model.Kraj = reader[1].ToString();
                model.Wojewodztwo = reader[2].ToString();
                model.Temperatura = int.Parse(reader[3].ToString());
                model.Foto = int.Parse(reader[4].ToString());
                model.Opis = reader[5].ToString();
                model.Opady = int.Parse(reader[6].ToString());
                model.Cisnienie = int.Parse(reader[7].ToString());
                model.Wiatr = int.Parse(reader[8].ToString());
                model.Id = int.Parse(reader[9].ToString());
            }
            reader.Close();

            query = string.Format("Select Dzien, Foto,Opis,Temperatura,Cisnienie from dbo.PogodaDni where IdPogoda = {0} order by 1", model.Id);
            cmd.CommandText = query;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var item = new WeatherNextDayModel();
                item.Dzien = reader[0].ToString();
                item.Foto = int.Parse(reader[1].ToString());
                item.Opis = reader[2].ToString();
                item.Temperatura = int.Parse(reader[3].ToString());
                item.Cisnienie = int.Parse(reader[4].ToString());
                model.Dni.Add(item);
            }
            reader.Close();


            connection.Close();
            model.Aktualizacja = DateTime.Now;
            var json = Helper.Serialize(model);
            return json;
        }

        public static List<string> GetCities()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["Db.Properties.Settings.DatabaseConnectionString"].ConnectionString;

            connection.Open();
            string query = string.Format("Select Miasto from dbo.Pogoda");
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            var model = new List<string>();
            while (reader.Read())
            {
                model.Add(reader[0].ToString());
            }
            reader.Close();
            
            connection.Close();
            return model;
        }
    }
}
