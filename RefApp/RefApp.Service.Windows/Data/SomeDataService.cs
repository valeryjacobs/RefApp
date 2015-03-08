using RefApp.Contracts.Models;
using RefApp.Contracts.Services;
using RefApp.Repositories.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Service.Windows.Data
{
    public class SomeDataService : ISomeDataService
    {


        public async Task<ObservableCollection<ISomeObjectInfo>> GetSubSetOfSomeObjects()
        {
            SomeObjectRepository someObjectRepository = new SomeObjectRepository();

            var someObjects = await someObjectRepository.GetSomeObjects();

            return someObjects;
        }

        public Task<ISomeObjectDetail> GetSomeObjectDetailWithSetOfSomeOtherObject(string someObjectId)
        {
            throw new NotImplementedException();
        }

        public Task<ISomeOtherObjectDetail> GetSomeOtherObjectDetails(string someOtherObjectId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ISomeOtherObjectInfo>> GetSubsetOfSomeOtherObjects()
        {
            throw new NotImplementedException();
        }
    }
}
