using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.DAL
{
    public class AppDbContext:IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
      
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<NoticeBoard> NoticeBoards { get; set; }
        public DbSet<NoticeSchedule> NoticeSchedules { get; set; }
        public DbSet<HomeRightNotice> HomeRightNotices { get; set; }
        public DbSet<WhyChoose> WhyChooses { get; set; }
       
        public DbSet<HomeEvent> HomeEvents { get; set; }
       
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Position> Positions { get; set; }
       
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<AboutBanner> AboutBanners { get; set; }
        public DbSet<AboutEduHome> AboutEduHomes { get; set; }
      
       
        public DbSet<CourseDetailCard> CourseDetailCards { get; set; }
     
        public DbSet<EventBanner> EventBanner { get; set; }

        public DbSet<BlogBanner> BlogBanners { get; set; }
       
        public DbSet<ContactAdress> ContactAdresses { get; set; }
        public DbSet<ContactBanner> ContactBanners { get; set; }
       
     
        public DbSet<Emails> Emails { get; set; }
        public DbSet<EventDetailCard> EventDetailCards { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<BlogDetailCard> BlogDetailCards { get; set; }
        public DbSet<LeaveReply> LeaveReplies { get; set; }


    }
}
