using Prism.Navigation;
using ProfileBook1804.Services.Managers;
using ProfileBook1804.Services.Repositorys;
using ProfileBook1804.Services.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProfileBook1804.ViewModels
{
    public class AddContactViewModel : ViewModelBase
    {
       
        private  ISettingsManager _settingsManager;
        private  IProfileManager _profileManager;
        private INavigationService _navigationService;
        public AddContactViewModel(ISettingsManager settingsManager, 
                                   ProfileManager profileManager, 
                                   INavigationService navigationService) : base(navigationService)
        {
            _settingsManager = settingsManager;
            _profileManager = profileManager;
        }

        private string _contactName;
        public string ContactName
        {
            get => _contactName;
            set => SetProperty(ref _contactName, value);
        }
        private string _contactNikName;
        public string ContactNikName
        {
            get => _contactNikName;
            set => SetProperty(ref _contactNikName, value);
        }
        private string _contactDiscription;
        public string ContactDiscription
        {
            get => _contactDiscription;
            set => SetProperty(ref _contactDiscription, value);
        }




    }
}
