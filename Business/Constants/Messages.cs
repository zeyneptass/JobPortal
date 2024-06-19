using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "User is added";
        public static string UserInvalid = "You entered an invalid username or password.";
        public static string UserRoleNonselected = "Please, choose a role in the system to progress.";
        public static string UsersListed = "Users are listed.";
        public static string MaintenanceTime = "The website is under maintenance.";
        public static string UserDelte = "User is deleted.";
        public static string UserUpdate = "User is updated";

        public static string UserDelete { get; internal set; }
    }
}
