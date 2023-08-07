﻿namespace Pronian.Database.Models
{
    public class Slider
    {

        public Slider(string offer, string title, string shortDescription, string buttonText, string url)
        {
            Offer = offer;
            Title = title;
            ShortDescription = shortDescription;
            ButtonText = buttonText;
            URL = url;
            Order = ++IdCounter;
        }
        public static int IdCounter { get; private set; }

        public string Offer { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string ButtonText { get; set; }
        public string URL { get; set; }
        public int Order { get; set; }
    }
}
