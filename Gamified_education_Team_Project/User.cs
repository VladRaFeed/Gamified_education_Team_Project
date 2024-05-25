using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    class User : InterfaceUser
    {
        private string name;
        private string surname;
        private string email;
        private string password;
        private string userId;
        private string userType;

        public User()
        {
            this.name = "";
            this.surname = "";
            this.email = "";
            this.password = "";
            this.userId = "";
            this.userType = "";
        }

        public User(string name, string surname, string email, string password, string userId, string userType)
        {
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
            UserId = userId;
            UserType = userType;
        }

        public string Name
        {
            get => this.name; 
            set => this.name = value;
        } 

        public string Surname
        {
            get => this.surname;
            set => this.surname = value;
        }

        public string Email
        {
            get => this.email; 
            set => this.email = value;
        }

        public string Password
        {
            get => this.password; 
            set => this.password = value;
        }

        public string UserId
        {
            get => this.userId; 
            set => this.userId = value;
        }

        public string UserType
        {
            get => this.userType; 
            set => this.userType = value;
        }
    }
}
