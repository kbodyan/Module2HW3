using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;

namespace Sweets.Services
{
    public class FindByManufactorService
    {
        public Sweet FindByManufactor(Sweet[] present, string key)
        {
            foreach (var item in present)
            {
                var temp = item as OutsourceMadeSweet;
                if (temp != null && temp.Manufacturer.Contains(key))
                {
                    return temp;
                }
            }

            return null;
        }
    }
}
