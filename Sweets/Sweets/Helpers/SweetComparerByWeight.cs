using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;

namespace Sweets.Helpers
{
    public class SweetComparerByWeight : IComparer<Sweet>
    {
        public int Compare(Sweet x, Sweet y)
        {
            return x.Weight.CompareTo(y.Weight);
        }
    }
}
