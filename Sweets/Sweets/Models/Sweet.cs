using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Helper;

namespace Sweets.Models
{
    public abstract class Sweet : IComparable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Calories { get; set; }
        public TypeOfPackage Package { get; set; }
        public int CompareTo(object obj)
        {
            return Name.CompareTo(((Sweet)obj).Name);
        }

        public abstract Sweet PutToPresent();
    }
}
