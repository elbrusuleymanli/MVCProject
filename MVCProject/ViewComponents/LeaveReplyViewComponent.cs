using Microsoft.AspNetCore.Mvc;
using MVCProject.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewComponents
{
    public class LeaveReplyViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public LeaveReplyViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var message = _context.LeaveReplies.FirstOrDefault();

            return View(message);
        }
    }
}
