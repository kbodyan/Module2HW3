using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;

namespace Sweets.Services
{
    public class PresentCreatorService
    {
        public Sweet[] CreatePresent(out double weight, Sweet[] storage, int quantity)
        {
            var present = new Sweet[quantity];
            var rand = new Random();
            weight = 0;
            for (var i = 0; i < present.Length; i++)
            {
                present[i] = storage[rand.Next(0, storage.Length)].PutToPresent();
                weight += present[i].Weight;
            }

            return present;
        }
    }
}
