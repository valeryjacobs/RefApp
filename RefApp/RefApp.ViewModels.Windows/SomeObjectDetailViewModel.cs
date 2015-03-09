using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Views;
using RefApp.Contracts.Models;
using RefApp.Contracts.Services;
using RefApp.Contracts.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefApp.ViewModels.Windows
{
    public class SomeObjectDetailViewModel : ViewModelBase, ISomeObjectDetailViewModel
    {
        public RelayCommand GoBack { get; set; }

        private ISomeDataService someDataService;
        private INavigationService navigationService;
        private ISomeObjectDetail selectedObjectDetail;

        string _testBinding;
        public string TestBinding
        {
            get { 
                return "hoi"; }
            set
            {
                _testBinding = value;
                RaisePropertyChanged("TestBinding");
            }
        }

        public ISomeObjectDetail SelectedObject
        {
            get
            {
                return selectedObjectDetail;
            }
            set
            {
                selectedObjectDetail = value;
                RaisePropertyChanged("SelectedObjectDetail");
            }
        }
        public SomeObjectDetailViewModel(ISomeDataService someDataService,
            INavigationService navigationService)
        {
            this.someDataService = someDataService;
            this.navigationService = navigationService;

            InitializeCommands();
        }

        private void InitializeCommands()
        {
            GoBack = new RelayCommand(() =>
            {
                navigationService.GoBack();
            });
        }

        public async void Initialize(object parameter)
        {
            SelectedObject =
                await someDataService.GetSomeObjectDetailWithSetOfSomeOtherObject(parameter.ToString());
        }
    }
}
