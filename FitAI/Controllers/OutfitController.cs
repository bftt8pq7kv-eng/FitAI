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

        public OutfitController()
        {
            _outfitService = new OutfitService();
        }

        [HttpPost("recommend")]
        public IActionResult RecommendOutfit([FromBody] OutfitRequest request)
        {
            var recommendations = _outfitService.GenerateOutfits(request);

            return Ok(recommendations);
        }
    }
}