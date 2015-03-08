using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.ViewModels
{
    public interface IViewModel
    {
        void Initialize(object parameter);
    }
}
