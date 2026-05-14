namespace FitAI.Models
{
    public class OutfitHistory
    {
        public int Id { get; set; }

        public string City { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;

        public string Style { get; set; } = string.Empty;

        public string Activity { get; set; } = string.Empty;

        public string Colors { get; set; } = string.Empty;

        public string Recommendation { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}