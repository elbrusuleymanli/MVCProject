using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public List<NoticeSchedule> NoticeSchedules { get; set; }
        public List<NoticeBoard> NoticeBoards { get; set; }
        public List<HomeRightNotice> RightNotices { get; set; }
        public List<WhyChoose> WhyChooses { get; set; }
        public List<HomeCourseTitle> CourseTitles { get; set; }
        public List<HomeCard> CourseCards { get; set; }
        public List<HomeEvent> Events { get; set; }
        public List<HomeEventRight> EventRights { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<HomeBlog> Blogs { get; set; }
        public List<Subscribe> Subscribes { get; set; }
       

    }
}
