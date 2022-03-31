using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
        public string Fullname { get; set; }
        public int PositionId { get; set; }
        public Position Position { get; set; }
        public string  BgImage { get; set; }
    }
}
