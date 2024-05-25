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
        string Email { get; set; }
        string Password { get; set; }
        string UserId { get; set; }
        string UserType { get; set; }
    }
}
