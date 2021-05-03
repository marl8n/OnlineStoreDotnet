using System.Collections.Generic;

namespace OnlineStoreDotNet.Models
{
    public class Sale:StoreBaseObject
    {
        public string ClientId { get; set; }
        public string ClientNit { get; set; }
        public States State { get; set; }
        public List<Product> Products { get; set; }
        public Sale(string ClientId, string ClientNit, States State, List<Product> Products):base()
        {
            this.ClientId = ClientId;
            this.ClientNit = ClientNit;
            this.State = States.Sold;
            this.Products = Products;
        }
    }
}