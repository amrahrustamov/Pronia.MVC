using Pronian.Database.Models;
using Pronian.ViewModels;

namespace Pronian.Database.Repositories
{
    public class SliderRepository
    {
        public static HomeViewModel HomeViewModels = new HomeViewModel();

        static SliderRepository()
        {
            HomeViewModels.sliders.Add(new Slider("75% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", "https://www.google.com", 1));
            HomeViewModels.sliders.Add(new Slider("65% Off", "New Plant", "Pronia, With 100% Natural, Organic &amp; Plant Shop.", "Discover Now", "https://www.google.com", 2));
        }
        public List<Slider> GetAll()
        {
            return HomeViewModels.sliders;
        }

    }
}
