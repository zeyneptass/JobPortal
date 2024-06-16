using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            // business codes
            // işlemin başarılı olup olmadığını döndürüp ve son kullanıcıya işlem ile ilgili bilgilendirme yapmak isteriz.
            _userDal.Add(user);
        }

        public List<User> GetAll()
        {
            // Bir methodda sadece bir değer dödürülür burada List değer döndürmüş
            // Aynı anda birden fazla değer döndürmek istersek encapsulation'dan faydalanmalıyız.
            return _userDal.GelAll();
        }

        public List<User> GetAllByRole(int roleId)
        {
            return _userDal.GelAll(u => u.RoleId == roleId);
        }

        public User GetById(int userId)
        {
            return _userDal.Get(p =>p.UserId == userId);
        }

        public List<UserDetailDto> GetUserDetails()
        {
            return _userDal.GetUserDetails();
        }
    }
}
