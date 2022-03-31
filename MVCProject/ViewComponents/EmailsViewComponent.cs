using Microsoft.AspNetCore.Mvc;
using MVCProject.DAL;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewComponents
{
    public class EmailsViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public EmailsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var email = _context.Emails.FirstOrDefault();
           
            return View(email);
        }


    }
}
