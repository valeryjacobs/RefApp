using RefApp.Contracts.Services;
using RefApp.Repositories.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Service.Windows.Data
{
    public class CacheDataService : ICacheDataService
    {
        public void ClearCache()
        {
            new CacheRepository().ClearCache();
        }
    }
}
