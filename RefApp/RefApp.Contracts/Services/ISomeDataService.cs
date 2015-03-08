using RefApp.Contracts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Services
{
    public interface ISomeDataService
    {
        Task<ObservableCollection<ISomeObjectInfo>> GetSubSetOfSomeObjects();
        Task<ISomeObjectDetail> GetSomeObjectDetailWithSetOfSomeOtherObject(string someObjectId);
        Task<ISomeOtherObjectDetail> GetSomeOtherObjectDetails(string someOtherObjectId);
        Task<List<ISomeOtherObjectInfo>> GetSubsetOfSomeOtherObjects();
    }
}
