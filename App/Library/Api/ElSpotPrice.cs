using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Api.ElSpotPrice
{
    
    public class Record
    {
        public DateTime HourUTC { get; set; }
        public DateTime HourDK { get; set; }
        public string PriceArea { get; set; }
        public double SpotPriceDKK { get; set; }
        public double SpotPriceEUR { get; set; }
    }

    public class Root
    {
        public int total { get; set; }
        public string sort { get; set; }
        public string dataset { get; set; }
        public List<Record> records { get; set; }
    }


}
