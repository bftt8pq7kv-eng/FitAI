namespace FitAI.Models
{
    public class OutfitRecommendation
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string UpperWear { get; set; } = string.Empty;

        public string LowerWear { get; set; } = string.Empty;

        public string Shoes { get; set; } = string.Empty;

        public string OuterWear { get; set; } = string.Empty;

        public string Accessory { get; set; } = string.Empty;

        public string Reason { get; set; } = string.Empty;
    }
}