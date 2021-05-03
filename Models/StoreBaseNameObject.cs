using System;

namespace OnlineStoreDotNet.Models
{
    public class StoreBaseNameObject:StoreBaseObject
    {
        public string Name { get; set; }
        public StoreBaseNameObject()
        {
            
        }
        public StoreBaseNameObject(string Name):base(true)
        {
            this.Name = Name;
        }
    }
}