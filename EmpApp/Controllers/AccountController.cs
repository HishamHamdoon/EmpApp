using EmpApp.Models;
using EmpApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmpApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager)
        {
            this.UserManager = userManager;
            this.signInManager = signInManager;
        }

        public UserManager<ApplicationUser> UserManager { get; }
        public SignInManager<IdentityRole> SignInManager { get; }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user  = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email ,
                    City = model.City
                };

                 var result = await UserManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    if (signInManager.IsSignedIn(User))
                    {
                        return RedirectToAction("ListUsers", "Adminstration");
                    }

                    await signInManager.SignInAsync(user,isPersistent:false);
                    return RedirectToAction("index","home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty,error.Description);
                }
            }

            return View(model);
        }

        [HttpPost]
       public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("index","home");
        }
        [HttpGet]
        [AllowAnonymous]
        public  IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
           
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync
                    (model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl) )
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }
                
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

                
            }
           
            return View(model);
        }

        [AcceptVerbs("Get","Post")]
        [AllowAnonymous]

        public async Task<IActionResult> IsEmailUsed(string email)
        {
            var user = await UserManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} email is Used");
            }
           
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenide()
        {
            return View();
        }
    }
 
}

