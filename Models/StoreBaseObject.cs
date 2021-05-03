using System;

namespace OnlineStoreDotNet.Models
{
    public class StoreBaseObject
    {
        public string UniqueId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public StoreBaseObject()
        {
            
        }
        public StoreBaseObject(bool NewObject)
        {
            if (NewObject) 
            {
                this.UniqueId = Guid.NewGuid().ToString();
                this.CreatedAt = DateTime.Now;
                this.UpdatedAt = DateTime.Now;
            }
        }
    }
}