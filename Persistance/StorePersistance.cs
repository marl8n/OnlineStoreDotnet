using System.Collections.Generic;
using OnlineStoreDotNet.Models;
using System;
using Newtonsoft.Json;
using System.IO;

namespace OnlineStoreDotNet.Persistance
{
    public class StorePersistance
    {
        public static void Save(List<Store> stores, string path)
        {
            using (var w = new StreamWriter(path))
            {
                w.Write(JsonConvert.SerializeObject(stores));
            }
        }

        public static Store Load(string path)
        {
            Store stores = null;
            if (File.Exists(path))
            {
                using (var r = new StreamReader(path))
                {
                    stores = JsonConvert.DeserializeObject<Store>(r.ReadToEnd());
                }
            }

            if (stores != null)
            {
                return stores;
            } else {
                return new Store();
            }
        }
    }
}