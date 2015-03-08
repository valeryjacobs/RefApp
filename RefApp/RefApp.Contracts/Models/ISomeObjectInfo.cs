using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Models
{
    public interface ISomeObjectInfo
    {
         int SomeIntProp { get; set; }

         string SomeStringProp { get; set; }

        List<ISomeOtherObjectInfo> SetOfOtherObject { get; set; }

    }
}
