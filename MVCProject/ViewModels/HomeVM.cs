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

        public List<CourseDetailCard> CourseDetailCards { get; set; }
        public List<HomeEvent> Events { get; set; }
        public List<EventDetailCard> EventDetailCards { get; set; }

        public List<BlogDetailCard> BlogDetailCards { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        
        public List<Subscribe> Subscribes { get; set; }
       

    }
}
