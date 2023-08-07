namespace Pronian.Database.Models
{
    public class Products
    {
        
        public Products(string name, string description, string url, string color, string size, decimal price)
        {
            Name = name;
            Description = description;
            URL = url;
            Color = color;
            Size = size;
            Price = price;
            ProductOrder = ++IdCounter;
        }
        public static int IdCounter { get; private set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int ProductOrder { get;}

    }
}
