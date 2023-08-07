using Pronian.Database.Models;

namespace Pronian.Database.Repositories
{
    public class ProductRepository
    {
        public static List<Products> products = new List<Products>();

        static ProductRepository()
        {
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23,1));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 2));    
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 3));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 4));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 5));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 6));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 7));
            products.Add(new Products("American Marigold", "description area", "https://www.example.com", "Light green", "Medium size", 23, 8));

        }
        public List<Products> GetAll()
        {
            return products;
        }
    }
}
