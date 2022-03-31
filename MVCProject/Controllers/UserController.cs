using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCProject.Constants;
using MVCProject.Models;
using MVCProject.Services;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IMailService _mailService;
        public UserController(UserManager<User> userManager,IMailService mailService,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _mailService = mailService;
            _signInManager = signInManager;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Login(LoginVM model)
        {
            if (!ModelState.IsValid) return View();

            var user =await _userManager.FindByNameAsync(model.Username);
            if (user == null)user= await _userManager.FindByEmailAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid request");

                return View();
            }
            //for block user
            if (!user.IsActive)
            {
                ModelState.AddModelError("", "Your account was blocked by admin");
                return View();
            }


            var signInResult =await _signInManager.PasswordSignInAsync(user, model.Password, true, false);

            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Invalid Request");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (!ModelState.IsValid) return View(model);
            var user = await _userManager.FindByNameAsync(model.Username);
            if (user != null)
            {
                ModelState.AddModelError("Username", "Existing username");
            
            
            return View();
            }

            User newUser = new User
            {
                Fullname = model.Fullname,
                UserName = model.Username,
                Email= model.Email
                           };

            var identityResult = await _userManager.CreateAsync(newUser, model.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

         await _userManager.AddToRoleAsync(newUser,RoleConstants.User);
            //create token
            var token =await _userManager.GenerateEmailConfirmationTokenAsync(newUser);
            //create link
            var link = Url.Action(nameof(ConfirmEmail), "User", new { newUser.UserName, token }, Request.Scheme);

            await _mailService.SendEmailAsync(new MailRequest
            {
                ToEmail = newUser.Email,
                Body = link,
                Subject = "Registration Confirm"
            });

            return RedirectToAction("Index","Home");
        }

        
        public async Task<IActionResult> ConfirmEmail(string username,string token)
        {
            var user = await  _userManager.FindByNameAsync(username);
            if (user == null) return BadRequest();

          var IdentityResult=await _userManager.ConfirmEmailAsync(user, token);

            if (!IdentityResult.Succeeded)
            {
                return BadRequest();
            };
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
