namespace OnlineStoreDotNet.Models
{
    public class Client:StoreBaseNameObject
    {
        public string Nit { get; set; }
        public Client()
        {
            
        }
        public Client(string Name, string Nit):base(Name)
        {
            this.Nit = Nit;
        }
    }
} 