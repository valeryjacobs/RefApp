using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Services
{
    public interface IPushNotificationService
    {
        string ChannelUri { get; set; }
        void RegisterChannelUriWithService();
    }
}
