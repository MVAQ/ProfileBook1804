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
        private  IRepository _reposytory;
        private  ISettingsManager _settingsManager;
        private  ProfileManager _profileManager;

        public AddContactViewModel(IRepository _reposytory, 
                                   ISettingsManager _settingsManager, 
                                   ProfileManager _profileManager, 
                                   INavigationService navigationService)
        {
            _reposytory = new Repository();
            _settingsManager = new SettingsManager();
            _profileManager = new ProfileManager();
           
        }



    }
}
