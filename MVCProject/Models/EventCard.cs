using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class EventCard
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public string Month { get; set; }
        public string Time { get; set; }
        public string City { get; set; }
        public string  Button { get; set; }

        [Required]
        [NotMapped]
        public IFormFile EventImageFile { get; set; }
    }
}
