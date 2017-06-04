
using System;
using System.Collections.Generic;

namespace Model
{
    /// <summary>
    /// Model danych pogody
    /// </summary>
    public class WeatherModel
    {
        public string Miasto { get; set; }
        public string Kraj { get; set; }
        public string Wojewodztwo { get; set; }
        public string Temperatura { get; set; }
        public int Foto { get; set; }
        public string Opis { get; set; }
        public string Opady { get; set; }
        public string Cisnienie { get; set; }
        public string Wiatr { get; set; }
        public DateTime Aktualizacja { get; set; }

        /// <summary>
        /// Informacja o pogodzie na kolejne dni
        /// </summary>
        public List<WeatherNextDayModel> Dni { get; set; }

    }

    /// <summary>
    /// Model danych pogody na kolejne dni
    /// </summary>
    public class WeatherNextDayModel
    {
        public int Id { get; set; }
        public int Foto { get; set; }
        public string Dzien { get; set; }
        public string Opis { get; set; }
        public string Temperatura { get; set; }
        public string Cisnienie { get; set; }
    }
}
