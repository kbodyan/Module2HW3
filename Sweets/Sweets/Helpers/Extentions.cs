using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;

namespace Sweets.Helpers
{
    public static class Extentions
    {
        public static string GiveReceipt(this SelfMadeSweet sweet)
        {
            return sweet.Receipt.ToString();
        }

        /* ! Студия не видит
        public static int CompareTo(this Sweet sweet, object obj)
        {
            return sweet.Name.CompareTo(((Sweet)obj).Name);
        }
        */
    }
}
