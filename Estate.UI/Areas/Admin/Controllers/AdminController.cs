﻿using EntityLayer.Entity;
using Estate.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Estate.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private UserManager<UserAdmin> _userManager;
        private SignInManager<UserAdmin> _signInManager;

        public AdminController(UserManager<UserAdmin> userManager, SignInManager<UserAdmin> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
                HttpContext.Session.SetString("Id", user.Id);
                HttpContext.Session.SetString("Fullname", user.FullName);
                return RedirectToAction("Index");
            }

            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("FullName");
            return RedirectToAction("Login");
        }
    }
}
