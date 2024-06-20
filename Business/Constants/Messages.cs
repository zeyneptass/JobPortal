using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserAdded = "You have successfully registered.";
        public static string UserInvalid = "You entered an invalid username or password.";
        public static string UserRoleNonselected = "Please, choose a role in the system to progress.";
        public static string UsersListed = "Users are listed.";
        public static string MaintenanceTime = "The website is under maintenance.";
        public static string UserDelete = "User is deleted.";
        public static string UserUpdate = "User is updated";

        public static string RoleNotSelected = "Please, select a role";

        public static string JobTypeAdd = "Job type is added.";
        public static string JobTypeDeleted = "Job type is deleted.";
        public static string JobTypeUpdated = "Job type is updated.";
        public static string JobTypeListed = "Job types are listed.";

        public static string EmailNameAlreadyExists = "There is a user with this email in the system.";
        public static string EnterANewPassword = "Your password must be at least 8 characters and contain uppercase, lowercase letters, numbers and special characters.";
        public static string NewPasswordMustBeDifferent = "Your new password is the same as the old one, please enter a different password.";
        public static string InvalidEmailOrPassword = "You entered the wrong password or email.";
        public static string LoginSuccessful = "You have successfully logged in.";


    }
}
