using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Gamified_education_Team_Project
{
    class Teacher : User
    {
        private string department;
        private string position;
        private string specialization;

        public Teacher(string department, string position, string specialization, string name, string surname, string email, string password, string userId, string userType) : base(name, surname, email, password, userId, userType)
        {
            this.department = department;
            this.position = position;
            this.specialization = specialization;
        }

        public string Department
        {
            get => this.department;
            set => this.department = value;
        }

        public string Position
        {
            get => this.position;
            set => this.position = value;
        }

        public string Specialization
        {
            get => this.specialization; 
            set => this.specialization = value;
        }

        public void TeacherMenu()
        {
            Console.WriteLine("Its teacher menu XD");
        }
    }
}
