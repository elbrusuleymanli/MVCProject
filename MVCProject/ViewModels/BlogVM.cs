﻿using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class BlogVM
    {
        public List<BlogCard> BlogCards { get; set; }
        public List<BlogBanner> BlogBanners { get; set; }
    }
}
