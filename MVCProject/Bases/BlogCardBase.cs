﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Bases
{
    public class BlogCardBase
    {
        public string Image { get; set; }
        public string LinkIcon { get; set; }
        public string Date { get; set; }
        public string CommentIcon { get; set; }
        public int CountComment { get; set; }
        public string Desc { get; set; }
        public string Button { get; set; }
    }
}
