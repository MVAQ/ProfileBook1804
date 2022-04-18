using System;
using System.Collections.Generic;
using System.Text;


namespace ProfileBook1804.Services.Settings
{
    public interface ISettingsManager
    {
        public int UserId { get; set; }

        public  void UserIdControlCurrent(int UserId);
    }
}
