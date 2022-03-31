using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.DAL;
using MVCProject.Models;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;

        public ContactController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            ContactVM model = new ContactVM
            {
                ContactAdresses=await _context.ContactAdresses.ToListAsync(),
                ContactBanners=await _context.ContactBanners.ToListAsync()
            };
            return View(model);
        }

     public async Task<JsonResult> addSubscribe(string email) {

            if (String.IsNullOrWhiteSpace(email)) return Json(400);
          
            bool isValid = IsValidEmail(email);
            if (!isValid)
            {
                return Json(500);
            }
            
            Emails emails = new Emails
            {
                Email=email
            };

            await _context.Emails.AddAsync(emails);
           await _context.SaveChangesAsync();
            return Json(200);
        
        }
        bool IsValidEmail(string email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

    }
}
