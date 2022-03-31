using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Slider
    {
        public int Id { get; set; }
    
        public string Image { get; set; }
      
        [StringLength(maximumLength:300)]
        public string  TitleUp { get; set; }

        [StringLength(maximumLength: 300)]
        public string TitleDown { get; set; }

        [StringLength(maximumLength: 300)]
        public string Desciption { get; set; }
        [StringLength(maximumLength: 50)]

        [Required (ErrorMessage ="You not finish yet")]
        public string Button { get; set; }
        public int Order { get; set; }

        [Required]
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
