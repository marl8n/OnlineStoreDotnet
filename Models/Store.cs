using System.Collections.Generic;

namespace OnlineStoreDotNet.Models
{
    public class Store:StoreBaseNameObject
    {
        List<Client> Clients = new List<Client>();
        List<Product> Products = new List<Product>();
        List<Sale> Sales = new List<Sale>();
        public Store()
        {
            
        }
    }
}