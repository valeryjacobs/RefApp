using RefApp.Contracts.Services;
using RefApp.Contracts.ViewModels;
using RefApp.Contracts.Views;
using RefApp.Service.Windows.Data;
using RefApp.Service.Windows.Infrastructure;
using RefApp.Shared;
using RefApp.ViewModels.Windows;
using RefApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            //ViewModel registration

            InstanceFactory.RegisterType<ISomeOtherObjectDetailViewModel, SomeOtherObjectDetailViewModel>();
            InstanceFactory.RegisterType<ISomeObjectDetailViewModel, SomeObjectDetailViewModel>();


            ////View registration

            InstanceFactory.RegisterType<ISomeOtherObjectDetailView, SomeOtherObjectDetailView>();
            InstanceFactory.RegisterType<ISomeObjectDetailView, SomeObjectDetailView>();


            ////Services registration
            InstanceFactory.RegisterType<ISomeDataService,
                SomeDataService>();
            InstanceFactory.RegisterType<INavigationService,
                NavigationService>();
            InstanceFactory.RegisterType<IDialogService, DialogService>();

            //InstanceFactory.RegisterType<IPushNotificationService, PushNotificationService>();
            //InstanceFactory.RegisterType<ITileService, TileService>();
            //InstanceFactory.RegisterType<IToastService, ToastService>();
            InstanceFactory.RegisterType<IStateService, StateService>();
            InstanceFactory.RegisterType<ICacheDataService, CacheDataService>();
        }

        public ISomeOtherObjectDetailViewModel SomeOtherObjectDetailViewModel
        {
            get
            {
                return InstanceFactory.GetInstance<ISomeOtherObjectDetailViewModel>();
            }
        }

        public ISomeObjectDetailViewModel SomeObjectDetailViewModel
        {
            get
            {
                return InstanceFactory.GetInstance<ISomeObjectDetailViewModel>();
            }
        }


    }
}
