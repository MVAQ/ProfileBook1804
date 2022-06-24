using ProfileBook1804.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using ProfileBook1804.Services.Settings;
using ProfileBook1804.Services.Repositorys;
using System.Linq;

namespace ProfileBook1804.Services.Managers
{
    public class ProfileManager : BindableBase, IProfileManager
    {
        ISettingsManager _settingsManager;
        IRepository _reposytory;

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
            set => SetProperty(ref _contactCreateDateTime, value);
        }
        public async Task<IEnumerable<ContactModel>> GetAllContactAsync()
        {
            
            var CurentID = _settingsManager.UserId;
            var UserContactModels = await _reposytory.GetAllAsync<ContactModel>();
            var AllUserContactModel = from UserContact in UserContactModels
                                      where UserContact.ContactIdUser == CurentID
                                      select UserContact;
            return AllUserContactModel;
        }
        public Task<IEnumerable<ContactModel>> GetAllUserContactAsync(int CurentID)
        {
            throw new NotImplementedException();
        }

        public async Task<ContactModel> RemoveContactAsync(ContactModel contact)
        {
           
            await _reposytory.DeleteAsync(contact);
            return contact;
        }

        public async Task<ContactModel> SaveContactAsync(ContactModel contact)
        {
           
            var NewContact = contact;
            NewContact.ContactIdUser = _settingsManager.UserId;
            await _reposytory.InsertAsync(NewContact);
            return NewContact;


        }

        public async Task<ContactModel> UpdateContactAsync(ContactModel contact)
        {
            var NewContact = contact;
            NewContact.ContactIdUser = _settingsManager.UserId;
            await _reposytory.UpdateAsync(NewContact);
            return NewContact;

        }
    }
}
