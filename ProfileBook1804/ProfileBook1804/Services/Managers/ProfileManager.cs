using ProfileBook1804.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace ProfileBook1804.Services.Managers
{
    public class ProfileManager : BindableBase, IProfileManager
    {

        private int _contactIdUser;
        public int ContactIdUser
        {
            get => _contactIdUser;
            set => SetProperty(ref _contactIdUser, value);
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

        private DateTime _contactCreateDateTime;
        public DateTime ContactCreateDateTime
        {
            get => _contactCreateDateTime;
            set => SetProperty(ref _contactCreateDateTime,value);
        }
        public Task<IEnumerable<ContactModel>> GetAllContactAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContactModel> RemoveContactAsync(ContactModel contact)
        {
            throw new NotImplementedException();
        }

        public Task<ContactModel> SaveContactAsync(ContactModel contact)
        {
            throw new NotImplementedException();
        }
    }
}
