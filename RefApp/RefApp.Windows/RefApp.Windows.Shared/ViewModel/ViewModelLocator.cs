/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:RefApp.Windows"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using Microsoft.Practices.ServiceLocation;
using RefApp.Contracts.Services;
using RefApp.Contracts.ViewModels;
using RefApp.Contracts.Views;
using RefApp.Service.Windows.Data;
using RefApp.Service.Windows.Infrastructure;
using RefApp.Shared;
using RefApp.ViewModels.Windows;
using RefApp.Windows.Views;

namespace RefApp.Windows.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {

            // InstanceFactory.RegisterType<ISomeObjectDetailViewModel,
            //    SomeObjectDetailViewModel>();

            // //View registration
            // InstanceFactory.RegisterType<ISomeObjectDetailView,
            //     SomeObjectDetailView>();


            // //Services registration
            // InstanceFactory.RegisterType<ISomeDataService,
            //     SomeDataService>();
            // InstanceFactory.RegisterType<INavigationService,
            //     NavigationService>();
            // InstanceFactory.RegisterType<IDialogService, DialogService>();
            // //InstanceFactory.RegisterType<IPushNotificationService, PushNotificationService>();

            // //InstanceFactory.RegisterType<ITileService, TileService>();
            //// InstanceFactory.RegisterType<IToastService, ToastService>();
            // InstanceFactory.RegisterType<IStateService, StateService>();
            // InstanceFactory.RegisterType<ICacheDataService, CacheDataService>();


            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            var navigationService = this.CreateNavigationService();
            SimpleIoc.Default.Register<INavigationService>(() => navigationService);
            SimpleIoc.Default.Register<IDialogService, DialogService>();
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<SomeObjectDetailViewModel>();
            SimpleIoc.Default.Register<IStateService, StateService>();

            //if (ViewModelBase.IsInDesignModeStatic)
            //{
            //    // Create design time view services and models
            //    SimpleIoc.Default.Register<IDataService, DesignDataService>();
            //}
            //else
            //{
                // Create run time view services and models
            SimpleIoc.Default.Register<ISomeDataService, SomeDataService>();
            //}

            SimpleIoc.Default.Register<ICacheDataService, CacheDataService>();

            


        }

        private INavigationService CreateNavigationService()
        {
            var navigationService = new NavigationService();
            navigationService.Configure("SomeObjectDetailView", typeof(SomeObjectDetailView));
            navigationService.Configure("SomeOtherObjectDetailView", typeof(SomeOtherObjectDetailView));


            return navigationService;
        }

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}