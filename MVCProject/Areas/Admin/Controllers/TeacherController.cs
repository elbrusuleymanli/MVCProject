using Microsoft.AspNetCore.Mvc;
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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _context;

        public TeacherController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var card = _context.Teachers.ToList();
            return View(card);
        }
        public async Task<IActionResult> Detail(int id)
        {
            var cards = await _context.Teachers.FindAsync(id);
            if (cards == null) return NotFound();
            return View(cards);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacherCard)
        {
            if (!ModelState.IsValid) return View();

            if (!teacherCard.TeacherImageFile.isImageCondition())
            {
                ModelState.AddModelError("CardImageFile", "Image type is wrong");
                return View();

            }

            var folderPath = FileConstants.TeacherImagePath;

            teacherCard.Image = FileUtils.CreateFile(folderPath, teacherCard.TeacherImageFile);
            await _context.Teachers.AddAsync(teacherCard);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var teacherCard = await _context.Teachers.FindAsync(id);
            if (teacherCard == null) return NotFound();

            return View(teacherCard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var teacherCard = await _context.Teachers.FindAsync(id);
            if (teacherCard == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.TeacherImagePath, teacherCard.Image);


            FileUtils.DeleteFile(fullPath);


            _context.Teachers.Remove(teacherCard);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var teacherCard = await _context.Teachers.FindAsync(id);

            if (teacherCard == null) return NotFound();

            return View(teacherCard);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, Teacher teacherCard)
        {
            var dbteacherCard = await _context.Teachers.FindAsync(id);

            if (dbteacherCard == null) return NotFound();
            if (id != teacherCard.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.TeacherImagePath, dbteacherCard.Image));

            dbteacherCard.Image = FileUtils.CreateFile(FileConstants.TeacherImagePath, teacherCard.TeacherImageFile);

            dbteacherCard.Fullname = teacherCard.Fullname;
            dbteacherCard.Position = teacherCard.Position;
            dbteacherCard.Title = teacherCard.Title;
            dbteacherCard.Description = teacherCard.Description;
            dbteacherCard.Degree = teacherCard.Degree;
            dbteacherCard.Experience = teacherCard.Experience;
            dbteacherCard.Hobby = teacherCard.Hobby;
            dbteacherCard.Faculty = teacherCard.Faculty;
            dbteacherCard.Email = teacherCard.Email;
            dbteacherCard.Phone = teacherCard.Phone;



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }
    }
}
