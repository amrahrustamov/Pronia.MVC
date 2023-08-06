namespace Pronian.Database.Models
{
    public class Slider
    {

        public Slider(string offer, string title, string shortDescription, string buttonText, int id)
        {
            Offer = offer;
            Title = title;
            ShortDescription = shortDescription;
            ButtonText = buttonText;
            Id = id;

        }

        public string Offer { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ButtonText { get; set; }
        public int Id { get; set; }
    }
}
