using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OnlineStoreDotNet.Models;

namespace OnlineStoreDotNet.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index() {
            List<Client> clients = new List<Client>();
            if(clients.Count == 0) {
                return View("EmptyClients");
            }
            return View();
        }
    }
}