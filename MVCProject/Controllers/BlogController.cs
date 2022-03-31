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
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult>  Index()
        {
            BlogVM model = new BlogVM
            {
                BlogBanners=await _context.BlogBanners.ToListAsync(),
                BlogCards = await _context.BlogCards.ToListAsync()
            };
            return View(model);
        }

        public async Task<IActionResult> Detail(int id)
        {
            BlogDetailCard blogDetailCard =await _context.BlogDetailCards.FirstOrDefaultAsync(b => b.Id == id);
            return View(blogDetailCard);
        }
    }
}
