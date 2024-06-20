﻿using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<List<User>> GetAllByRole(int roleId);
        IDataResult<List<UserDetailDto>> GetUserDetails();
        IDataResult<User> Login(string email, string password);
        IResult Add(User user);
        IDataResult<User> GetById(int userId);
        IResult Update(User user);
        IResult Delete(User user);
    }
}
