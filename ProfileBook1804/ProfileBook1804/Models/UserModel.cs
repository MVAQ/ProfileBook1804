using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProfileBook1804.Models
{
    internal class UserModel : IEntityBase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set;}
        public string UserLogin { get; set;}
        public string UserPassword { get; set;}
        public string UserPasswordConfirm { get; set;}
        public DateTime UserCreateDateTime { get; set; }

    }
}
