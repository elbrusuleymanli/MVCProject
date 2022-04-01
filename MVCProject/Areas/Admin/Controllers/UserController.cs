
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Areas.Admin.ViewModels;
using MVCProject.Constants;
using MVCProject.DAL;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles=RoleConstants.Admin)]
    public class UserController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;

        public UserController(AppDbContext context, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _context = context;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task<IActionResult>  Index()
        {
        var users=  await _context.Users.ToListAsync();

            List<UserVM> usersList = new List<UserVM>();

            foreach (var user in users)
            {
                usersList.Add(new UserVM
                {   Id= user.Id,
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    IsActive =user.IsActive,
                    Roles = string.Join(",", await _userManager.GetRolesAsync(user))

                });
            }
            
            return View(usersList);
        }

        public async Task<IActionResult> GetRoles(string id)
        {
            var user =await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            var roles =await _userManager.GetRolesAsync(user);
          
            ViewBag.Fullname = user.Fullname;
            ViewBag.UserId = user.Id;
           
            return View(roles); 
           
        }

        public async Task<IActionResult> RemoveRole(string id, string roleName)
        {
            var user =await _userManager.FindByIdAsync(id);
           
            if (user == null) return NotFound();

            await _userManager.RemoveFromRoleAsync(user, roleName);

            return RedirectToAction(nameof(GetRoles),new { user.Id});
        }

        public async Task<IActionResult> AddRoles (string id)
        {

            var roles =await _context.Roles.Select(r => r.Name).ToListAsync();

            AddRoleVM model = new AddRoleVM()
            {
                Roles = roles,
                UserId = id
            };
            
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task <IActionResult> AddRoles(string id, AddRoleVM model)
        {
            var user =await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View(model);

            await _userManager.AddToRoleAsync(user, model.RoleName);

            return RedirectToAction(nameof(GetRoles), new { id });

        }

        public async Task<IActionResult> ChangePassword(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            ViewBag.Fullname = user.Fullname;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(string id, ChangePasswordVM model)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            if (!ModelState.IsValid) return View();

            //if (!ModelState.IsValid) return View();

            //if (!await _userManager.CheckPasswordAsync(user, model.OldPassword))
            //{
            //    ModelState.AddModelError(nameof(ChangePasswordVM.OldPassword), "Incorrect password");
            //    return View();
            //}
            //var idResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);



            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

           
           
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors )
                {
                    ModelState.AddModelError("", error.Description);
                }
               return View() ;
            }

            //var newPassword = await _userManager.AddPasswordAsync(user, model.NewPassword);

            //if (!newPassword.Succeeded)
            //{
            //    foreach (var error in newPassword.Errors)
            //    {
            //        ModelState.AddModelError("", error.Description);
            //    }
            //    return View();
            //}
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> ToggleBlock(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null) return View();

            user.IsActive = !user.IsActive;

             _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

    }
}
