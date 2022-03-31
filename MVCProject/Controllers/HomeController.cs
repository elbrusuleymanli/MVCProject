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

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult > Index()
        {


            HomeVM model = new HomeVM
            {
                Sliders = await _context.Sliders.OrderBy(s => s.Order).ToListAsync(),
                NoticeSchedules = await _context.NoticeSchedules.ToListAsync(),
                NoticeBoards = await _context.NoticeBoards.ToListAsync(),
                RightNotices = await _context.HomeRightNotices.ToListAsync(),
                WhyChooses = await _context.WhyChooses.ToListAsync(),
                CourseTitles = await _context.HomeCourseTitles.ToListAsync(),
               
                CourseCards = await _context.HomeCards.ToListAsync(),
                Events = await _context.HomeEvents.ToListAsync(),
                EventRights = await _context.HomeEventRights.ToListAsync(),
                Testimonials = await _context.Testimonials.Include(t => t.Position).ToListAsync(),
                Blogs = await _context.HomeBlogs.ToListAsync(),
                Subscribes=await _context.Subscribes.ToListAsync()
            };

            return View(model);
        }
   
     
    }
}

