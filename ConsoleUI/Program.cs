// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

//GetUserEmails();
//GetRoles();

DtoTest();

static void GetUserEmails()
{
    UserManager userManager = new(new EfUserDal());
    foreach (var user in userManager.GetAll())
    {
        Console.WriteLine(user.Email);
    }
}

static void GetRoles()
{
    RoleManager roleManager = new(new EfRoleDal());
    foreach (var role in roleManager.GetRoles())
    {
        Console.WriteLine(role.UserRole);
    }
}

static void DtoTest()
{
    UserManager userManager = new(new EfUserDal());
    foreach (var user in userManager.GetUserDetails())
    {
        Console.WriteLine(user.UserId + "/" + user.Email + "/" + user.UserRole);
    }
}