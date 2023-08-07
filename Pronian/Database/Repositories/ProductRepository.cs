using Pronian.Database.Models;

namespace Pronian.Database.Repositories
{
    public class ProductRepository
    {
        public static List<Products> products = new List<Products>();

        static ProductRepository()
        {
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));    
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23));

        }
        public List<Products> GetAll()
        {
            return products;
        }
    }
}
