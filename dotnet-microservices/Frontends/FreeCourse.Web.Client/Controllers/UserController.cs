using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace FreeCourse.Web.Client.Controllers
{
   
    public class UserController : Controller
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _userService.GetUser());
        }
    }
}
