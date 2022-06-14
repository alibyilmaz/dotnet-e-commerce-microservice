﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models;

namespace FreeCourse.Web.Client.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserViewModel> GetUser();

    }
}
