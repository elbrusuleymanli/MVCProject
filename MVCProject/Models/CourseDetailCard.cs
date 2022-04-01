using Microsoft.AspNetCore.Http;
using MVCProject.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class CourseDetailCard
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Descr { get; set; }
        public string Description { get; set; }
        public string BannerImage { get; set; }
        public string BannerTopic { get; set; }

        

        [Required]
        [NotMapped]
        public IFormFile CardImageFile { get; set; }





    }
}
