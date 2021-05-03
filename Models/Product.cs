namespace OnlineStoreDotNet.Models
{
    public class Product:StoreBaseNameObject
    {
        public int Quantity { get; set; }
        public double StockPrice { get; set; }
        public double Price { get; set; }

        public Product()
        {
            
        }
        public Product(string Name, int Quantity, double StockPrice, double Price):base(Name)
        {
            this.Quantity = Quantity;
            this.StockPrice = StockPrice;
            this.Price = Price;
        }
    }
}