using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Pronian.Database.Models;
using Pronian.Database.Repositories;

namespace Pronian.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Slider()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ManageProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Slider(string offer, string title, string description, string url, int order)
        {
            SliderRepository sliderRepository = new SliderRepository();
            List<Slider> sliders = sliderRepository.GetAll();
            foreach (Slider slider in sliders)
            {
                if (slider.Order == order)
                {
                    slider.Offer = offer;
                    slider.Title = title;
                    slider.ShortDescription = description;
                    slider.URL = url;
                    slider.Order = order;
                }
            }

            return View();
        }
        [HttpPost]
        public IActionResult ManageProduct(string productName, string url, string color, string size, decimal price, int order)
        {
            

            return View();
        }

    }
}
