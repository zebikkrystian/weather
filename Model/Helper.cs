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
    }
}
