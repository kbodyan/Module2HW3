using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets.Models
{
    internal class MultiPackedSweet : FactorySweet, ICloneable
    {
        public int QuantityInPackage { get; set; }
        public double PriceOfEach { get; set; }

        public object Clone()
        {
            var temp = MemberwiseClone();
            ((MultiPackedSweet)temp).Name = (string)Name.Clone();
            return temp;
        }

        public override Sweet PutToPresent()
        {
            return Clone() as Sweet;
        }
    }
}
