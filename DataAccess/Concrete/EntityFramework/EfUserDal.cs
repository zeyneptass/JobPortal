using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, JobPortalContext>, IUserDal
    {
        public List<UserDetailDto> GetUserDetails()
        {
            using (JobPortalContext context = new())
            {
                var result = from u in context.Users
                             join r in context.Roles
                             on u.RoleId equals r.RoleId
                             select new UserDetailDto 
                             { 
                                 Email=u.Email,UserId=u.UserId,UserRole= r.UserRole
                             };
                return result.ToList();
            }
        }
    }
}
