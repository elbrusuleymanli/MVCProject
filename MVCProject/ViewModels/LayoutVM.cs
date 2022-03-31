using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class LayoutVM
    {
        public List<Layout> Layouts { get; set; }
        public List<Footer> Footers { get; set; }
    }
}
