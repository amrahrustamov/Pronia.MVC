namespace Pronian.Database.Models
{
    public class Products
    {
        public Products(string name, string description, string uRL, string color, string size, decimal price, int productOrder)
        {
            Name = name;
            Description = description;
            URL = uRL;
            Color = color;
            Size = size;
            Price = price;
            ProductOrder = productOrder;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public int ProductOrder { get;}

    }
}
