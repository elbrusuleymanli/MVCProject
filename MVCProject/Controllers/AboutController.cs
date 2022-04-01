using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.DAL;
using MVCProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Controllers
{
    


    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            


            AboutVM model = new AboutVM
            {
                AboutBanners = await _context.AboutBanners.ToListAsync(),
                Teachers=await _context.Teachers.ToListAsync(),
                AboutEduHomes = await _context.AboutEduHomes.ToListAsync(),
                Testimonials= await _context.Testimonials.Include(t=>t.Position).ToListAsync()
        };
return View(model);
    }
}
 }