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
    public class EventController : Controller
    { 
        private readonly AppDbContext _context;
       
          public EventController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {

            EventVM model = new EventVM
            {
                EventBanners = await _context.EventBanner.ToListAsync(),
                EventDetailCards=await _context.EventDetailCards.ToListAsync()
            };
      

        

           return View(model);
    }
        public async Task<IActionResult> Detail(int id)
        {

            EventDetailCard eventDetailCard = await _context.EventDetailCards.FirstOrDefaultAsync(e => e.Id == id);
            if (eventDetailCard == null) return NotFound();
            return View(eventDetailCard);
        }

    }
}
