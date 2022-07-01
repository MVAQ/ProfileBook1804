using Prism.Navigation;
using ProfileBook1804.Models;
using ProfileBook1804.Services.Managers;
using ProfileBook1804.Services.Repositorys;
using ProfileBook1804.Services.Settings;
using System.Collections.ObjectModel;


namespace ProfileBook1804.ViewModels
{
    public partial class MainListViewModel : ViewModelBase
    {
          public IRepository _repository;
          public ISettingsManager _settingsManager;
          public IProfileManager _profileManager;

        public ObservableCollection<ContactModel> _contactList;
        public ObservableCollection<ContactModel> ContactList
        {
            get => _contactList;
            set => SetProperty(ref _contactList, value);
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
        public MainListViewModel(IRepository repository, ISettingsManager settingsManager, IProfileManager profileManager, INavigationService navigationService) : base(navigationService)
        {
            _repository = repository;
            _settingsManager = settingsManager;
            _profileManager = profileManager;


            ContactList = new ObservableCollection<ContactModel>()
            {
                new ContactModel
                {
                    ContactName = "Vasya",
                    ContactNikName = "Tor",
                    ContactDiscription = "Lorem ipsum dolor sit amet"
                },
                 new ContactModel
                {
                    ContactName = "Semen",
                    ContactNikName = "Sova",
                    ContactDiscription = "Lorem ipsum dolor sit amet"
                }
            };

          

        }
        
        
    }
}
