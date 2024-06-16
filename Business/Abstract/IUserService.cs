﻿using Entities.Concrete;
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
        List<User> GetAll();
        List<User> GetAllByRole(int roleId);
        List<UserDetailDto> GetUserDetails();
        void Add(User user);
        User GetById(int userId);
    }
}