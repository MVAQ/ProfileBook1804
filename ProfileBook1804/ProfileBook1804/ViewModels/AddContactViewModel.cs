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
        


    }
}
