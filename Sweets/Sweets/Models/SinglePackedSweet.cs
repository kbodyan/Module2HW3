using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets.Models
{
    public class SinglePackedSweet : FactorySweet, ICloneable
    {
        public object Clone()
        {
            var temp = MemberwiseClone();
            ((SinglePackedSweet)temp).Name = (string)Name.Clone();
            return temp;
        }

        public override Sweet PutToPresent()
        {
            return Clone() as Sweet;
        }
    }
}
