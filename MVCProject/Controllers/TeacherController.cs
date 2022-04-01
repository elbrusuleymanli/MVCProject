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


            var teachers = await _context.Teachers.ToListAsync();
         

            return View(teachers);
        }
        public async Task<IActionResult> Detail (int id)
        {
            Teacher teachers =await _context.Teachers.FindAsync( id);
            return View(teachers);
        }
    }
}
