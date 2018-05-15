using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DA2_2018_LabCompras_tlevi29.Models
{
    public class WeatherApiResponse
    {
        public APILocation Location { get; set; }
        public APICurrent Current { get; set; }

        public class APILocation
        {
            public string Name { get; set; }
            public string Region { get; set; }
            public string Country { get; set; }
            public double Lat { get; set; }
            public double Lon { get; set; }
            public string Tz_id { get; set; }
            public int Localtime_epoch { get; set; }
            public DateTime Localtime { get; set; }
        }

        public class APICurrent
        {
            public double Temp_c { get; set; }
            public APICurrentCondition Condition { get; set; }

            public class APICurrentCondition
            {
                public string Text { get; set; }
                public string Icon { get; set; }
            }
        }

    }
}


    //"location": {
    //    "name": "Paris",
    //    "region": "Ile-de-France",
    //    "country": "France",
    //    "lat": 48.87,
    //    "lon": 2.33,
    //    "tz_id": "Europe/Paris",
    //    "localtime_epoch": 1525485238,
    //    "localtime": "2018-05-05 3:53"
   
    //"current": {
    //    "temp_c": 11,
    //    "condition": {
    //        "text": "Clear",
    //        "icon": "//cdn.apixu.com/weather/64x64/night/113.png"
