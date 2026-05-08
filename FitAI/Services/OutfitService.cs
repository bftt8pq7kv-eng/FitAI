using FitAI.Models;

namespace FitAI.Services
{
    public class OutfitService
    {
        public List<OutfitRecommendation> GenerateOutfits(OutfitRequest request)
        {
            var outfits = new List<OutfitRecommendation>();

            outfits.Add(new OutfitRecommendation
            {
                Id = 1,
                Title = "Casual Günlük Kombin",
                UpperWear = "Beyaz Oversize Tişört",
                LowerWear = "Siyah Baggy Jean",
                Shoes = "Beyaz Sneaker",
                OuterWear = "Kot Ceket",
                Accessory = "Gümüş Kolye",
                Reason = $"{request.City} hava durumuna ve {request.Style} tarzına uygun rahat kombin."
            });

            outfits.Add(new OutfitRecommendation
            {
                Id = 2,
                Title = "Minimal Şehir Kombini",
                UpperWear = "Bej Sweatshirt",
                LowerWear = "Krem Kumaş Pantolon",
                Shoes = "Chunky Sneaker",
                OuterWear = "Trench Coat",
                Accessory = "Deri Saat",
                Reason = $"{request.EventType} etkinliği için modern görünüm."
            });

            outfits.Add(new OutfitRecommendation
            {
                Id = 3,
                Title = "Spor Kombin",
                UpperWear = "Dry-fit Hoodie",
                LowerWear = "Jogger",
                Shoes = "Running Ayakkabı",
                OuterWear = "Şişme Yelek",
                Accessory = "Sırt Çantası",
                Reason = $"{request.Gender} kullanıcı için dinamik kombin önerisi."
            });

            return outfits;
        }
    }
}