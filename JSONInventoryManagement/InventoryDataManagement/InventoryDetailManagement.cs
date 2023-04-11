﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONInventoryManagement.InventoryDataManagement
{
    public class InventoryDetailManagement
    {
        public void ReadJSONFile(string file)
        {
            var jsondata = File.ReadAllText(file);
            List<Inventory> inventories = JsonConvert.DeserializeObject<List<Inventory>>(jsondata); //json file data into string data
            foreach (var data in inventories)
            {
                Console.WriteLine("Inventory Name: " + data.Name + "\n" + "Weight: " + data.Weight + "\n" + "Price Per Kg: " + data.PricePerKg + "\n" + "Total Price: " + data.Weight * data.PricePerKg);
            }
        }
    }
}