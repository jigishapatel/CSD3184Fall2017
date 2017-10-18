using System;
using SQLite;

namespace DBLogin
{
    public class LoginTable
    {
        [PrimaryKey, AutoIncrement, Column("_Id")]  
  
        public int id { get; set; } // AutoIncrement and set primarykey  
  
        [MaxLength(25)]  
  
        public string username { get; set; }  
  
        [MaxLength(15)]  
  
        public string password { get; set; } 
    }
}
