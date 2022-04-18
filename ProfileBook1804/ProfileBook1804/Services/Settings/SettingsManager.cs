using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace ProfileBook1804.Services.Settings
{
    public class SettingsManager : ISettingsManager
    {
        public int UserId
        { 
            get => Preferences.Get(nameof(UserId), 0);
            set => Preferences.Set(nameof(UserId), value); 
        }

        public void UserIdControlCurrent(int UserId)
        {
            Preferences.Set(nameof(UserId), UserId);
        }
    }
}
