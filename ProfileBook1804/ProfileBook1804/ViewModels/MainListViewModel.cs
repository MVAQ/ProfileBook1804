using ProfileBook1804.Models;
using ProfileBook1804.Services.Managers;
using ProfileBook1804.Services.Repositorys;
using ProfileBook1804.Services.Settings;
using System.Collections.ObjectModel;


namespace ProfileBook1804.ViewModels
{
    public partial class MainListViewModel
    {
        public IRepository _repository;
        public ISettingsManager _settingsManager;
        public IProfileManager _profileManager;

        private readonly ObservableCollection<ContactModel> _contactList;

        public MainListViewModel(IRepository repository, ISettingsManager settingsManager, IProfileManager profileManager)
        {
            _repository = repository;
            _settingsManager = settingsManager;
            _profileManager = profileManager;
            _contactList = new ObservableCollection<ContactModel>();



        }

    }
}
