using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreDotNet.Models;
using OnlineStoreDotNet.Persistance;

namespace OnlineStoreDotNet.Controllers 
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            Store store = StorePersistance.Load("Stores.json");
            if (store != null) {
                return View(store);
            } else {
                return View();
            }
        }
    }
}