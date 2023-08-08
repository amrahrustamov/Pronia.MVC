using Pronian.Database.Models;
using Pronian.ViewModels;

namespace Pronian.Database.Repositories
{
    public class ProductRepository
    {
        public static HomeViewModel HomeViewModels = new HomeViewModel();

        static ProductRepository()
        {
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            HomeViewModels.Products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));

        }
        public List<Products> GetAll()
        {
            return HomeViewModels.Products;
        }
    }
}
