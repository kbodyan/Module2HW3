using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets.Models
{
    public class SelfMadeSweet : HandMadeSweet, ICloneable
    {
        public string Receipt { get; set; }
        public object Clone()
        {
            var temp = MemberwiseClone();
            ((SelfMadeSweet)temp).Name = (string)Name.Clone();
            ((SelfMadeSweet)temp).Receipt = (string)Receipt.Clone();
            return temp;
        }

        public override Sweet PutToPresent()
        {
            return Clone() as Sweet;
        }
    }
}
