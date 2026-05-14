using FitAI.Models;
using OpenAI.Chat;

namespace FitAI.Services
{
    public class OutfitService
    {
        private readonly IConfiguration _configuration;
        private readonly WeatherService _weatherService;

        public OutfitService(IConfiguration configuration, WeatherService weatherService)
        {
            _configuration = configuration;
            _weatherService = weatherService;
        }

        public async Task<string> GenerateOutfitAsync(OutfitRequest request)
        {
            var apiKey = _configuration["OpenAI:ApiKey"];

            var weather = await _weatherService.GetWeatherAsync(request.City);

            var client = new ChatClient("gpt-4.1-mini", apiKey);

            var prompt = $@"
Şehir: {request.City}
Hava durumu: {weather}
Cinsiyet: {request.Gender}
Tarz: {request.Style}
Etkinlik: {request.EventType}
Renk tercihi: {request.ColorPreference}

Bu kullanıcı için hava durumuna ve tarzına uygun kombin önerisi yap.
Üst giyim, alt giyim, ayakkabı, dış giyim, aksesuar ve kısa gerekçe ver.
";

            var completion = await client.CompleteChatAsync(prompt);

            return completion.Value.Content[0].Text;
        }
        public async Task<string> GetWeatherInfoAsync(string city)
        {
            return await _weatherService.GetWeatherAsync(city);
        }
    }
}