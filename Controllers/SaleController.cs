using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreDotNet.Models;

namespace OnlineStoreDotNet.Controllers
{
    public class SaleController : Controller
    {
        public IActionResult Index()
        {
            List<Sale> sales = new List<Sale>();
            
            if (sales.Count < 1) 
            {
                return View("EmptySales");
            }
            return View(sales);
        }
    }
}