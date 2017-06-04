using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Model
{
    public static class Helper
    {
        public static string GetData(string cityCode)
        {
            WeatherModel m = new WeatherModel();
            if (cityCode.ToLower().Contains("cz"))
            {
                m = new WeatherModel
                {
                    Miasto = "Częstochowa",
                    Kraj = "Polska",
                    Wojewodztwo = "śląskie",
                    Cisnienie = "1010 hPa",
                    Foto = 1,
                    Opady = "12 mm/m2",
                    Opis = "Słonecznie, bez opadów",
                    Temperatura = "30 °C",
                    Wiatr = "5m/s N"                    
                };
            }
            if (cityCode.ToLower().Contains("war"))
            {
                m = new WeatherModel
                {
                    Miasto = "Warszawa",
                    Kraj = "Polska",
                    Wojewodztwo = "mazowieckie",
                    Cisnienie = "1010 hPa",
                    Foto = 4,
                    Opady = "30 mm/m2",
                    Opis = "Burze i silne opady deszczu",
                    Temperatura = "21 °C",
                    Wiatr = "7,8 m/s N"
                };
            }
            if (cityCode.ToLower().Contains("gd"))
            {
                m = new WeatherModel
                {
                    Miasto = "Gdańsk",
                    Kraj = "Polska",
                    Wojewodztwo = "gdańskie",
                    Cisnienie = "1000 hPa",
                    Foto = 3,
                    Opady = "5 mm/m2",
                    Opis = "Lekkie opady deszczu",
                    Temperatura = "21 °C",
                    Wiatr = "4 m/s N"
                };
            }
            m.Aktualizacja = DateTime.Now;
            m.Dni = new List<WeatherNextDayModel>
            {
                new WeatherNextDayModel
                {
                    Id=1,
                    Foto = 3,
                    Opis = "Lekkie opady deszczu",
                    Cisnienie = "1034 hPa",
                    Temperatura = "28 °C",
                    Dzien = DateTime.Now.AddDays(1).ToString("dddd")
                },
                new WeatherNextDayModel
                {
                    Id=1,
                    Foto = 2,
                    Opis = "Lekkie zachmurzenie",
                    Cisnienie = "1005 hPa",
                    Temperatura = "24 °C",
                    Dzien = DateTime.Now.AddDays(2).ToString("dddd")
                },
                new WeatherNextDayModel
                {
                    Id=1,
                    Foto = 4,
                    Opis = "Burze i silny deszcz",
                    Cisnienie = "1001 hPa",
                    Temperatura = "20 °C",
                    Dzien = DateTime.Now.AddDays(3).ToString("dddd")
                }
            };
            var json = Serialize(m);
            return json;
        }

        public static string Serialize(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
