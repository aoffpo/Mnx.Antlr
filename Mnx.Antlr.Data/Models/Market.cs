using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mnx.Antlr.Data.Models
{
    public class Market
    {
       // [JsonProperty("market_id")]
        public int Id { get; set; }
        //[JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("range")]
        public int Range { get; set; }
        [JsonProperty("timeZone")]
        public string TimeZone { get; set; }
        [JsonProperty("cities")]
        public List<City> Cities { get; set; }
    }
}
