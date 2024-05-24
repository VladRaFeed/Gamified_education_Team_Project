using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamified_education_Team_Project
{
    interface InterfaceUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        int Password { get; set; }
        int UserId { get; set; }
        int UserType { get; set; }
    }
}
