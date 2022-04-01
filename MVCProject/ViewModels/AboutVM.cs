using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class AboutVM
    {
        public List<AboutEduHome> AboutEduHomes { get; set; }
        public List<AboutBanner> AboutBanners { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
