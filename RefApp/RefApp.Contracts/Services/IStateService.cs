using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Services
{
    public interface IStateService
    {
        string Parameter { get; set; }
        string ViewName { get; set; }
        void SaveState();
        void LoadState();
        void AddState(string viewName, string parameter);
    }
}
