using Pronian.Database.Models;
namespace Pronian.Database.Repositories
{
    public class SliderRepository
    {
        public static List<Slider> sliders = new List<Slider>();

        static SliderRepository()
        {
            sliders.Add(new Slider("75% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", "#"));
            sliders.Add(new Slider("65% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", "#"));
        }
        public List<Slider> GetAll()
        {
            return sliders;
        }

    }
}
