using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    internal class OpenWeatherMapAPI
    {
        public static void Weather()
        {

            HttpClient client = new HttpClient();
            string apiKey = APIIgnore.APIKey();
            Console.WriteLine("Please enter a city:");
            string cityName = Console.ReadLine();
            string weatherEndpoint = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
            string weatherResponse = client.GetStringAsync(weatherEndpoint).Result;
            JObject weatherObject = JObject.Parse(weatherResponse);
            Console.WriteLine($"The current temperature is {weatherObject["main"]["temp"]}F.");

        }
    }
}
