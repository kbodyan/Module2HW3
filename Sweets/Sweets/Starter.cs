using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweets.Models;
using Sweets.Services;
using Sweets.Helpers;

namespace Sweets
{
    public class Starter
    {
        private const int _presentSize = 20;
        private StorageCreator _storageCreator;
        private PresentCreatorService _presentCreatorService;
        private SweetComparerByWeight _comparerByWeight;
        private FindByManufactorService _searcherByManufactor;

        public Starter()
        {
            _storageCreator = new StorageCreator();
            _presentCreatorService = new PresentCreatorService();
            _comparerByWeight = new SweetComparerByWeight();
            _searcherByManufactor = new FindByManufactorService();
        }

        public void Run()
        {
            var storage = _storageCreator.CreateStorage();
            double weight;
            var present = _presentCreatorService.CreatePresent(out weight, storage, _presentSize);
            Array.Sort(present);
            Array.Sort(present, _comparerByWeight);
            var resultOfSearch = _searcherByManufactor.FindByManufactor(present, "ООО Рога");
        }
    }
}
