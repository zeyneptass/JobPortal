using Business.Abstract;
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

        public Role GetRoleById(int id)
        {
            return _roleDal.Get(r=> r.RoleId== id);
        }

        public List<Role> GetRoles()
        {
            return _roleDal.GelAll();
        }
    }
}
