using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.Contracts.Services
{
    public interface IDialogService
    {
        void ShowDialog(string message);
        void ShowDeleteConfirmation();
        void ShowAddToFavoriteConfirmation();
        void ShowPushNotificationQuestion();
    }
}
