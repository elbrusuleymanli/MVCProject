﻿using Microsoft.AspNetCore.Http;
using MVCProject.Bases;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class CourseCard:CardBase
    {
        public int Id { get; set; }
       
        [Required]
        [NotMapped]
        public IFormFile CardImageFile { get; set; }

    }
}
