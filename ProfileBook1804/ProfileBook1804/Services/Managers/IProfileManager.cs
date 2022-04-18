using ProfileBook1804.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace ProfileBook1804.Services.Managers
{
    public interface IProfileManager
    {
        public Task<IEnumerable<ContactModel>> GetAllContactAsync();
        public Task<ContactModel> SaveContactAsync(ContactModel contact);
        public Task<ContactModel> RemoveContactAsync(ContactModel contact);

    }
}
