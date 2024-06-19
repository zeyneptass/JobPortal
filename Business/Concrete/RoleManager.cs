using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        IRoleDal _roleDal; //dataAccess üzerine gevşek bağlılık vardır

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public IDataResult<Role> GetRoleById(int roleId)
        {
            var role = _roleDal.Get(r => r.RoleId == roleId);
            if (role != null)
            {
                return new SuccessDataResult<Role>(role);
            }
            return new ErrorDataResult<Role>(Messages.RoleNotSelected);
        }

        public IDataResult<List<Role>> GetRoles()
        {
            return new SuccessDataResult<List<Role>>(_roleDal.GetAll());
        }

        public IDataResult<List<Role>> GetRolesByType(string roleType)
        {
            var role = _roleDal.Get(r => r.UserRole == roleType);
            if (role != null)
            {
                return new SuccessDataResult<List<Role>>(roleType);
            }
            return new ErrorDataResult<List<Role>>();
        }

    }
}
