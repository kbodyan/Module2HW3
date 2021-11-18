using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Helper;

namespace Sweets.Models
{
    public abstract class Sweet
    {
        protected double _weight;
        protected TypeOfPackage _package;
        protected Color _packageColor;
    }
}
