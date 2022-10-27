using Library.Api.ElSpotPrice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repository
{
    public class SpotPriceRepo
    {
        private readonly HttpClient _client = new HttpClient();
        private List<Record> records = new();

        public List<Record> Get()
        {
            Load();
            return records;
        }

        public void Save(string path)
        {

        }

        public void Load()
        {
            var response = _client.GetAsync("http://gruppe6.simonstochholm.dk/api/pricedetails").Result;

            var Root = response.Content.ReadFromJsonAsync<Root>().Result;

            records = Root.records;
        }
    }
}
