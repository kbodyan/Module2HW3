using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweets.Models
{
    public abstract class HandMadeSweet : Sweet
    {
        public int ShelfLife { get; set; }
    }
}
