using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;

namespace Sweets.Services
{
    public class StorageCreator
    {
        public Sweet[] CreateStorage()
        {
            var result = new Sweet[]
            {
                new SinglePackedSweet { Name = "Лединец", Weight = 30, Calories = 100, Package = Helper.TypeOfPackage.Skin, Price = 12.50 },
                new SinglePackedSweet { Name = "Шоколадка", Weight = 100, Calories = 1200, Package = Helper.TypeOfPackage.Skin, Price = 24.30 },
                new MultiPackedSweet { Name = "конфеты Стрела", Weight = 350, Calories = 1500, Package = Helper.TypeOfPackage.Box, Price = 75.00, QuantityInPackage = 20 },
                new OutsourceMadeSweet { Name = "пряник Тульский", Weight = 250, Calories = 550, Package = Helper.TypeOfPackage.None, Price = 15.00, Manufacturer = "ООО Копыта", ShelfLife = 30 },
                new OutsourceMadeSweet { Name = "мафин", Weight = 150, Calories = 300, Package = Helper.TypeOfPackage.Skin, Price = 25.00, Manufacturer = "ООО Рога", ShelfLife = 15 },
                new SelfMadeSweet { Name = "пирожное Картошка", Weight = 200, Calories = 600, Package = Helper.TypeOfPackage.Paper, ShelfLife = 15, Receipt = "Our secret" }
            };
            return result;
        }
    }
}
