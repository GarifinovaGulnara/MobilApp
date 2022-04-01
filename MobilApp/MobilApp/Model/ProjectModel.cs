using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace MobilApp.db
{
    [Table("Project77")]
    public class ProjectModel
    {
        public ProjectModel()
        {
        }

        public ProjectModel(string name, string description, string phoneNum, string email, string adress)
        {
            Name = name;
            Description = description;
            PhoneNum = phoneNum;
            Email = email;
            Adress = adress;
        }

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Unique]
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}