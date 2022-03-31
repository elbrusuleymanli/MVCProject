using Microsoft.AspNetCore.Identity;
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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;



        public CourseController(AppDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {

            CourseVM model = new CourseVM
            {
                CourseBanners = await _context.CourseBanners.ToListAsync(),
                CourseCards = await _context.CourseCards.ToListAsync(),
                CourseDetailCards = await _context.CourseDetailCard.ToListAsync()
            };

            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            CourseDetailCard courseDetailCards = await _context.CourseDetailCard.FirstOrDefaultAsync(c => c.Id == id);
            if (courseDetailCards == null) return NotFound();

            
            return View(courseDetailCards);
        }
        [HttpPost]
        
        public async Task<JsonResult> SendMessage(LeaveReply model)
        {

            if (model==null) return Json(400);

            bool isValid = IsValidEmail(model);
            if (!isValid)
            {
                return Json(500);
            }

            LeaveReply reply = new LeaveReply
            {
                Email = model.Email,
                Name = model.Name,
                Subject = model.Subject,
                Text = model.Text

            };

            await _context.LeaveReplies.AddAsync(reply);
            await _context.SaveChangesAsync();
            return Json(200);

        }
        bool IsValidEmail(LeaveReply model)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(model.Email);
                return addr.Address == model.Email;
            }
            catch
            {
                return false;
            }
        }




    } 
}

