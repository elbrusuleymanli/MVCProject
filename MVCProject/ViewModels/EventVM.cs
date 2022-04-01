using MVCProject.Controllers;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class EventVM
    {
     
        public List<EventBanner> EventBanners { get; set; }
        public List<EventDetailCard> EventDetailCards { get; set; }
    }
}
