using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ProfileBook1804.Models
{
    public class ContactModel : IEntityBase
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ContactIdUser { get; set; }
        public string ContactImage { get; set; }
        public string ContactName { get; set; }
        public string ContactNikName { get; set; }
        public string ContactDiscription { get; set; }
        public DateTime ContactCreateDateTime { get; set; }





    }
}
