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
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()
        {
            var cards = await _context.CourseDetailCards.ToListAsync(); 
            return View(cards);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var cards = await _context.CourseDetailCards.FindAsync(id);
            if (cards == null) return NotFound();
            return View(cards);

        }
        
        public IActionResult Create()
        {
            return View();
        }


             [HttpPost]
            [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create(CourseDetailCard courseCard)
        {
            if (!ModelState.IsValid) return View();
           
            if (!courseCard.CardImageFile.isImageCondition())
            {
                ModelState.AddModelError("CardImageFile", "Image type is wrong");
                return View();

            }

            var folderPath = FileConstants.CourseImagePath;

            courseCard.Image = FileUtils.CreateFile(folderPath, courseCard.CardImageFile);
            await _context.CourseDetailCards.AddAsync(courseCard);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var courseCard= await _context.CourseDetailCards.FindAsync(id);
            if (courseCard == null) return NotFound();

            return View(courseCard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var courseCard = await _context.CourseDetailCards.FindAsync(id);
            if (courseCard == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.CourseImagePath, courseCard.Image);


            FileUtils.DeleteFile(fullPath);


            _context.CourseDetailCards.Remove(courseCard);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var courseCard = await _context.CourseDetailCards.FindAsync(id);

            if (courseCard == null) return NotFound();

            return View(courseCard);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, CourseDetailCard courseCard)
        {
            var dbcourseCard = await _context.CourseDetailCards.FindAsync(id);

            if (dbcourseCard == null) return NotFound();
            if (id != courseCard.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.CourseImagePath, dbcourseCard.Image));

            dbcourseCard.Image = FileUtils.CreateFile(FileConstants.CourseImagePath, courseCard.CardImageFile);

            dbcourseCard.Title = courseCard.Title;
            dbcourseCard.Descr = courseCard.Descr;
            
           


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

    }
}
