using FitAI.Models;
using FitAI.Services;
using Microsoft.AspNetCore.Mvc;

namespace FitAI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OutfitController : ControllerBase
    {
        private readonly OutfitService _outfitService;

        public OutfitController(OutfitService outfitService)
        {
            _outfitService = outfitService;
        }

        [HttpPost("recommend")]
        public async Task<IActionResult> RecommendOutfit([FromBody] OutfitRequest request)
        {
            var recommendation = await _outfitService.GenerateOutfitAsync(request);

            return Ok(new
            {
                recommendation
            });
        }
        [HttpPost("weather")]
        public async Task<IActionResult> GetWeather([FromBody] OutfitRequest request)
        {
            var weather = await _outfitService.GetWeatherInfoAsync(request.City);

            return Ok(new
            {
                city = request.City,
                weather = weather
            });
        }
        
    }
}