using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class EventDetailCard
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Descr { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Adress { get; set; }
        [Required]
        [NotMapped]
        public IFormFile EventImageFile { get; set; }
    }
}
