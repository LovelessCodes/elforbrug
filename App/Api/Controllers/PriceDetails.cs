using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Library.Api;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceDetails : ControllerBase
    {
        private readonly HttpClient _npClient;
        private readonly HttpClient _currencyClient;
        public double fixedCosts { get; set; } = 0.723 + 0.00229 + 0.061 + 0.049;
        public double taxRate { get; set; } = 0.25;
        public double EurInDKK { get; set; }


        public PriceDetails()
        {
            _npClient = new()
            {
                BaseAddress = new Uri("https://api.energidataservice.dk/dataset/")
            };
            _currencyClient = new()
            {
                BaseAddress = new Uri("https://api.apilayer.com/exchangerates_data/convert?to=EUR&from=DKK&amount=1")
            };
            _currencyClient.DefaultRequestHeaders.Add("apikey", "DNbpM9ew2O2IZcrKbsJzpIDSJWg3DiU6");

            var currencyJSON = _currencyClient.GetStringAsync("");
            Library.Api.CurrencyConvert.Root currency = JsonConvert.DeserializeObject<Library.Api.CurrencyConvert.Root>(currencyJSON.Result);
            EurInDKK = currency.result;

        }

        [HttpGet]
        public async Task<IActionResult> GetSpotPrices()
        {
            var jsonResponse = _npClient.GetStringAsync("Elspotprices?filter={\"PriceArea\": \"DK1,DK2\"}");
            Library.Api.ElSpotPrice.Root myDeserializedClass = JsonConvert.DeserializeObject<Library.Api.ElSpotPrice.Root>(await jsonResponse);

            myDeserializedClass.records.ForEach(r =>
            {
                r.SpotPriceDKK += fixedCosts * 1000;
                r.SpotPriceDKK += (taxRate * r.SpotPriceDKK);
                r.SpotPriceEUR = (r.SpotPriceDKK * EurInDKK);
            });
            
            return Ok(myDeserializedClass);
    }
}
}
