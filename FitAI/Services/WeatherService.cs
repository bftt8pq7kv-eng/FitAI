using System.Text.Json;

namespace FitAI.Services
{
    public class WeatherService
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _httpClient;

        public WeatherService(IConfiguration configuration)
        {
            _configuration = configuration;
            _httpClient = new HttpClient();
        }

        public async Task<string> GetWeatherAsync(string city)
        {
            var apiKey = _configuration["Weather:ApiKey"];

            var url =
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric&lang=tr";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                return "Hava durumu alınamadı";
            }

            var json = await response.Content.ReadAsStringAsync();

            using JsonDocument doc = JsonDocument.Parse(json);

            var temp =
                doc.RootElement
                .GetProperty("main")
                .GetProperty("temp")
                .GetDecimal();

            var description =
                doc.RootElement
                .GetProperty("weather")[0]
                .GetProperty("description")
                .GetString();

            return $"{temp}°C, {description}";
        }
    }
}