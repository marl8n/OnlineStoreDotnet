using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreDotNet.Models;

namespace OnlineStoreDotNet.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {
            List<Product> products = new List<Product>{
                new Product("Cheetos", 42, 12.00, 16.00),
                new Product("Doritos", 42, 10.00, 12.00),
                new Product("Snacks", 42, 18.00, 20.00),
                new Product("Nachos", 42, 4.00, 8.00),
                new Product("Jalapeños", 42, 4.00, 7.00),
            };

            if(products.Count < 1)
            {
                return View("EmptyProducts");
            }

            return View(products);
        }

        public IActionResult SingleProduct() {
            var p = new Product("Cheetos", 42, 12.00, 16.00);
            return View(p);
        }
    }
}