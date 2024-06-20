using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Business;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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
        [ValidationAspect(typeof(UserValidator))]
        public IResult Add(User user)
        {
            IResult result = BusinessRules.Run(CheckIfEmailExists(user.Email), ChoosingPasswordFunctions(user.Password));
            if (result != null)
            {
                return result;
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccessResult(Messages.UserDelete);
        }

        public IDataResult<List<User>> GetAll()
        {
            // Bir methodda sadece bir değer dödürülür burada List değer döndürmüş
            // Aynı anda birden fazla değer döndürmek istersek encapsulation'dan faydalanmalıyız.
            if(DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<User>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<User>>(_userDal.GetAll(),Messages.UsersListed);
        }
        public IDataResult<List<User>> GetAllByRole(int roleId)
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(u => u.RoleId == roleId));
        }
        public IDataResult<User> GetById(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.UserId == userId));
        }
        public IDataResult<List<UserDetailDto>> GetUserDetails()
        {
            return new SuccessDataResult<List<UserDetailDto>>(_userDal.GetUserDetails());
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult Update(User user)
        {
            IResult result = BusinessRules.Run(CheckIfEmailExists(user.Email), ChoosingPasswordFunctions(user.Password), CheckIfNewPasswordIsDifferent(user.UserId, user.Password));
            if (result != null)
            {
                return result;
            }
            _userDal.Update(user);
            return new SuccessResult(Messages.UserUpdate);
        }
        public IDataResult<User> Login(string email, string password)
        {
            var user = _userDal.Get(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                return new ErrorDataResult<User>(Messages.InvalidEmailOrPassword);
            }
            return new SuccessDataResult<User>(user, Messages.LoginSuccessful);
        }

        [ValidationAspect(typeof(UserValidator))]
        public IResult CheckIfEmailExists(string userEmail)
        {
            var result = _userDal.GetAll(u => u.Email == userEmail).Any();
            if (result)
            {
                return new ErrorResult(Messages.EmailNameAlreadyExists);
            }
            return new SuccessResult();
        }

        [ValidationAspect(typeof (UserValidator))]
        public IResult ChoosingPasswordFunctions(string password)
        {
            if (!(password.Length >=8 && password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit)))
            {
                return new ErrorResult(Messages.EnterANewPassword);
            }
            return new SuccessResult(); 
        }
        [ValidationAspect(typeof(UserValidator))]
        private IResult CheckIfNewPasswordIsDifferent(int userId, string newPassword)
        {
            var user = _userDal.Get(u => u.UserId == userId);
            if (user.Password == newPassword)
            {
                return new ErrorResult(Messages.NewPasswordMustBeDifferent);
            }
            return new SuccessResult();
        }

    }
}
