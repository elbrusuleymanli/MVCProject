using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class CourseVM
    {
        public List<CourseBanner> CourseBanners { get; set; }
        public List<CourseDetailCard> CourseDetailCards { get; set; }
        public List<CourseCard> CourseCards { get; set; }
    }
}
