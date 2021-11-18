using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets.Models
{
    public class OutsourceMadeSweet : HandMadeSweet, ICloneable
    {
        public string Manufacturer { get; set; }
        public double Price { get; set; }

        public object Clone()
        {
            var temp = MemberwiseClone();
            ((OutsourceMadeSweet)temp).Name = (string)Name.Clone();
            ((OutsourceMadeSweet)temp).Manufacturer = (string)Manufacturer.Clone();
            return temp;
        }

        public override Sweet PutToPresent()
        {
            return Clone() as Sweet;
        }
    }
}
