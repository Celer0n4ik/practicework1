using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    static async Task Main(string[] args)
    {
        string apiKey = "4a696473498865f7bf508384303b4877";

        string city;

        if (args.Length > 0)
        {
            city = string.Join(" ", args);
        }
        else
        {
            city = Console.ReadLine();
        }

        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

                HttpResponseMessage response = await client.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();

                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);

                if (data.cod != "404")
                {
                    string mainInfo = data.weather[0].main;
                    string description = data.weather[0].description;
                    double temperature = data.main.temp - 273.15;

                    Console.WriteLine($"Weather in {city}:");
                    Console.WriteLine($"Main: {mainInfo}");
                    Console.WriteLine($"Description: {description}");
                    Console.WriteLine($"Temperature: {temperature:F2}°C");
                }
                else
                {
                    Console.WriteLine("City not found");
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
        Console.ReadLine();
    }
}
