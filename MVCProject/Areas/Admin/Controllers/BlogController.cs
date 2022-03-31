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
            var blogCard = await _context.BlogCards.ToListAsync();
            return View(blogCard);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var cards = await _context.BlogCards.FindAsync(id);
            if (cards == null) return NotFound();
            return View(cards);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BlogCard blogCard)
        {
            if (!ModelState.IsValid) return View();

            if (!blogCard.BlogImageFile.isImageCondition())
            {
                ModelState.AddModelError("CardImageFile", "Image type is wrong");
                return View();

            }

            var folderPath = FileConstants.BlogImagePath;

            blogCard.Image = FileUtils.CreateFile(folderPath, blogCard.BlogImageFile);
            await _context.BlogCards.AddAsync(blogCard);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var blogCard = await _context.BlogCards.FindAsync(id);
            if (blogCard == null) return NotFound();

            return View(blogCard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var blogCard = await _context.BlogCards.FindAsync(id);
            if (blogCard == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.BlogImagePath, blogCard.Image);


            FileUtils.DeleteFile(fullPath);


            _context.BlogCards.Remove(blogCard);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var blogCard = await _context.BlogCards.FindAsync(id);

            if (blogCard == null) return NotFound();

            return View(blogCard);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, BlogCard blogCard)
        {
            var dbblogCard = await _context.BlogCards.FindAsync(id);

            if (dbblogCard == null) return NotFound();
            if (id != blogCard.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.BlogImagePath, dbblogCard.Image));

            dbblogCard.Image = FileUtils.CreateFile(FileConstants.BlogImagePath, blogCard.BlogImageFile);

            dbblogCard.Date = blogCard.Date;
            dbblogCard.CommentIcon = blogCard.CommentIcon;
            dbblogCard.CountComment = blogCard.CountComment;
            dbblogCard.Desc = blogCard.Desc;
            dbblogCard.Button = blogCard.Button;
           



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

    }
}
