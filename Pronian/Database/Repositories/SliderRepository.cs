using Pronian.Database.Models;
namespace Pronian.Database.Repositories
{
    public class SliderRepository
    {
        List<Slider> sliders = new List<Slider>();

        public SliderRepository()
        {
            sliders.Add(new Slider("75% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", 1));
            sliders.Add(new Slider("65% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", 2));
        }
        public List<Slider> GetAll()
        {
            return sliders;
        }

    }
}
