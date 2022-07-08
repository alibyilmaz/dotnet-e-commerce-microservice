﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Web.Client.Models;
using FreeCourse.Web.Client.Services.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace FreeCourse.Web.Client.Controllers
{
    public class AuthController : Controller
    {
        private readonly IIdentityService _identityService;

        public AuthController(IIdentityService identityService)
        {
            _identityService = identityService; 
        }
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInInput signInInput)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var response = await _identityService.SignIn(signInInput);
            if (!response.IsSuccessful)
            {

                response.Errors.ForEach(x =>
                {
                    ModelState.AddModelError(String.Empty, x);
                });
               
                return View();
            }
            return RedirectToAction(nameof(Index), "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await _identityService.RevokeRefreshToken();
            return RedirectToAction(nameof(HomeController.IndexAsync), "Home");
        }
    }
}
