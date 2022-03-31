using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCProject.DAL;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    { 
        private readonly AppDbContext _context;

        public MessageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var message = _context.LeaveReplies.ToList();
            return View(message);
        }


        public async Task<IActionResult> Delete(int id)
        {
            var message = await _context.LeaveReplies.FindAsync( id);
            if (message == null) return NotFound();

            _context.LeaveReplies.Remove(message);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
