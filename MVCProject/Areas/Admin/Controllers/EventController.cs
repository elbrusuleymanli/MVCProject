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
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var eventCard = await _context.EventDetailCards.ToListAsync();
            return View(eventCard);
        }
      
        public async Task<IActionResult> Detail(int id)
        {
            var cards = await _context.EventDetailCards.FindAsync(id);
            if (cards == null) return NotFound();
            return View(cards);

        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EventDetailCard eventCard)
        {
            if (!ModelState.IsValid) return View();

            if (!eventCard.EventImageFile.isImageCondition())
            {
                ModelState.AddModelError("CardImageFile", "Image type is wrong");
                return View();

            }

            var folderPath = FileConstants.EventImagePath;

            eventCard.Image = FileUtils.CreateFile(folderPath, eventCard.EventImageFile);
            await _context.EventDetailCards.AddAsync(eventCard);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var eventCard = await _context.EventDetailCards.FindAsync(id);
            if (eventCard == null) return NotFound();

            return View(eventCard);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCard(int id)
        {
            var eventCard = await _context.EventDetailCards.FindAsync(id);
            if (eventCard == null) return NotFound();

            var fullPath = Path.Combine(FileConstants.EventImagePath, eventCard.Image);


            FileUtils.DeleteFile(fullPath);


            _context.EventDetailCards.Remove(eventCard);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Update(int id)
        {
            var eventCard = await _context.EventDetailCards.FindAsync(id);

            if (eventCard == null) return NotFound();

            return View(eventCard);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int id, EventDetailCard eventCard)
        {
            var dbeventCard = await _context.EventDetailCards.FindAsync(id);

            if (dbeventCard == null) return NotFound();
            if (id != eventCard.Id) return BadRequest();
            if (!ModelState.IsValid) return View();

            FileUtils.DeleteFile(Path.Combine(FileConstants.EventImagePath, dbeventCard.Image));

            dbeventCard.Image = FileUtils.CreateFile(FileConstants.EventImagePath, eventCard.EventImageFile);

            dbeventCard.Descr = eventCard.Descr;
            dbeventCard.StartDate = eventCard.StartDate;
            dbeventCard.EndDate = eventCard.EndDate;
            dbeventCard.Adress = eventCard.Adress;
           



            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));



        }

    }
}
