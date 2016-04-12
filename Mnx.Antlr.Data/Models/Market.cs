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
        public int Id { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Range { get; set; }
        public string TimeZone { get; set; }
        public List<City> Cities { get; set; }
    }
}
