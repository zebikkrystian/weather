using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Klasa z metodami pocniczymi do pobierania i przesyłania danych
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Buduje dane o pogodzie - metoda ta powinna pobierać dane z bazy/api, ale na potrzeby programu dane są stałe. 
        /// </summary>
        /// <param name="cityCode">Miasto dla którego szukamy pogody</param>
        /// <returns>Dane o pogodzie</returns>
        public static string BuildData(string cityCode)
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

        /// <summary>
        /// Serializuje obiekt do Jsona
        /// </summary>
        /// <param name="obj">Obiekt do konwersji.</param>
        /// <returns>Json</returns>
        public static string Serialize(object obj)
        {
            string json = JsonConvert.SerializeObject(obj);
            return json;
        }

        /// <summary>
        /// Deserializuje json na obiekt
        /// </summary>
        /// <typeparam name="T">Oczekiwany typ</typeparam>
        /// <param name="json">Json do konwersji</param>
        /// <returns>Obiekt</returns>
        public static T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// Deserializuje json na obiekt
        /// </summary>
        /// <typeparam name="T">Oczekiwany typ</typeparam>
        /// <param name="json">Json do konwersji</param>
        /// <returns>Obiekt</returns>
        public static WeatherModel DeserializeResponse(string response)
        {
            JObject jObject = JObject.Parse(response);
            var list = jObject["list"];
            return new WeatherModel();
        }
    }
}
