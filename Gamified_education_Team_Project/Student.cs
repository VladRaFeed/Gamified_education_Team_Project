using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    class Student : User
    {
        private int course;
        private string group;
        private string specialization;
        private int balance;
        private Achivement[] achivements;
        private string[] completedTopics;

        public Student(int course, string group, string specialization, int balance, Achivement[] achivements, string[] completedTopics, string name, string surname, string email, string password, string userId, string userType) : base(name, surname, email, password, userId, userType)
        {
            this.course = course;
            this.group = group;
            this.specialization = specialization;
            this.balance = balance;
            this.achivements = achivements;
            this.completedTopics = completedTopics;
        }

        public int Course
        {
            get => this.course;
            set => this.course = value;
        }

        public string Group
        {
            get => this.group;
            set => this.group = value;
        }

        public string Specialization
        {
            get => this.specialization; 
            set => this.specialization = value;
        }

        public int Balance
        {
            get => this.balance;
            set => this.balance = value;
        }

        public Achivement[] Achivements
        {
            get => this.achivements;
            set => this.achivements = value;
        }

        public string[] CompletedTopics
        {
            get => this.completedTopics;
            set => this.completedTopics = value;
        }

        public void StudentMenu()
        {
            Console.WriteLine("Its student menu ;(");
        }
    }
}
