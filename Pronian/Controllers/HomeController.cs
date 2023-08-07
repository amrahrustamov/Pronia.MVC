using System;
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
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ManageProductList()
        {
            return View();
        }
        [HttpGet]
        public IActionResult EditProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Shop()
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
                    break;
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(string productName, string description, string url, string color, string size, decimal price, int order)
        {
            ProductRepository productRepository = new ProductRepository();
            List<Products> products = productRepository.GetAll();

            products.Add(new Products(productName, description, url, color, size, price));

            return View();
        }
        [HttpPost]
        public IActionResult EditProduct(string productName, string description, string url, string color, string size, decimal price, int order)
        {
            ProductRepository productRepository = new ProductRepository();
            List<Products> products = productRepository.GetAll();

            foreach (Products product in products)
            {
                if (product.ProductOrder == order)
                {
                    product.Name = productName;
                    product.Description = description;
                    product.URL = description;
                    product.Color = url;
                    product.Size = size;
                    product.Price = price;
                    break;
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteProduct(string productName, string description, string url, string color, string size, decimal price, int order)
        {
            ProductRepository productRepository = new ProductRepository();
            List<Products> products = productRepository.GetAll();

            foreach (Products product in products)
            {
                if (product.ProductOrder == order)
                {
                    ProductRepository.products.Remove(product);
                    break;
                }
            }
            return View();
        }
    }
}
