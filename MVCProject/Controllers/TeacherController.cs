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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            TeacherVM model = new TeacherVM
            {
                TeacherBanners = await _context.TeacherBanners.ToListAsync(),
                TeacherCards=await _context.TeacherCards.ToListAsync()
            };

            return View(model);
        }
        public async Task<IActionResult>Detail (int id)
        {
            TeacherDetailCard teachers =await _context.TeacherDetailCards.FirstOrDefaultAsync(t => t.Id == id);
            return View(teachers);
        }
    }
}
