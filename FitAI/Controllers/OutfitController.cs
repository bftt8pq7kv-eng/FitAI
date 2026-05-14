using FitAI.Data;
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
        private readonly ApplicationDbContext _context;

        public OutfitController(OutfitService outfitService, ApplicationDbContext context)
        {
            _outfitService = outfitService;
            _context = context;
        }

        [HttpPost("recommend")]
        public async Task<IActionResult> RecommendOutfit([FromBody] OutfitRequest request)
        {
            var recommendation = await _outfitService.GenerateOutfitAsync(request);

            var history = new OutfitHistory
            {
                City = request.City,
                Gender = request.Gender,
                Style = request.Style,
                Activity = request.EventType,
                Colors = request.ColorPreference,
                Recommendation = recommendation
            };

            _context.OutfitHistories.Add(history);
            await _context.SaveChangesAsync();

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
                weather
            });
        }

        [HttpGet("history")]
        public IActionResult GetHistory()
        {
            var history = _context.OutfitHistories
                .OrderByDescending(x => x.CreatedAt)
                .ToList();

            return Ok(history);
        }
    }
}