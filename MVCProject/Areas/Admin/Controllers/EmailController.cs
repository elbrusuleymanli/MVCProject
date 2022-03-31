using Microsoft.AspNetCore.Mvc;
using MVCProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EmailController : Controller
    {
        private readonly AppDbContext _context;

        public EmailController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var email = _context.Emails.ToList();
            return View(email);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.Emails.FindAsync(id);
            if (message == null) return NotFound();

            _context.Emails.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
