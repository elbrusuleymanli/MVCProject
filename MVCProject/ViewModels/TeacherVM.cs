using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class TeacherVM
    {
        public List<TeacherBanner> TeacherBanners { get; set; }
        public List<TeacherCard> TeacherCards { get; set; }

    }
}
