using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.Constants;
using MVCProject.DAL;
using MVCProject.Extensions;
using MVCProject.Models;
using MVCProject.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var blogCard = await _context.BlogDetailCards.ToListAsync();
            return View(blogCard);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var cards = await _context.BlogDetailCards.FindAsync(id);
            if (cards == null) return NotFound();
            return View(cards);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogDetailCard blogCard)
        {
            if (!ModelState.IsValid) return View();

            if (!blogCard.BlogImageFile.isImageCondition())
            {
                ModelState.AddModelError("CardImageFile", "Image type is wrong");
                return View();

            }

            var folderPath = FileConstants.BlogImagePath;

            blogCard.Image = FileUtils.CreateFile(folderPath, blogCard.BlogImageFile);
            await _context.BlogDetailCards.AddAsync(blogCard);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var blogCard = await _context.BlogDetailCards.FindAsync(id);
            if (blogCard == null) return NotFound();

            return View(blogCard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var blogCard = await _context.BlogDetailCards.FindAsync(id);
            if (blogCard == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.BlogImagePath, blogCard.Image);


            FileUtils.DeleteFile(fullPath);


            _context.BlogDetailCards.Remove(blogCard);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var blogCard = await _context.BlogDetailCards.FindAsync(id);

            if (blogCard == null) return NotFound();

            return View(blogCard);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, BlogDetailCard blogCard)
        {
            var dbblogCard = await _context.BlogDetailCards.FindAsync(id);

            if (dbblogCard == null) return NotFound();
            if (id != blogCard.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.BlogImagePath, dbblogCard.Image));

            dbblogCard.Image = FileUtils.CreateFile(FileConstants.BlogImagePath, blogCard.BlogImageFile);

            dbblogCard.Date = blogCard.Date;
          
            dbblogCard.CountComment = blogCard.CountComment;
            dbblogCard.Desc = blogCard.Desc;
            
           



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

    }
}
