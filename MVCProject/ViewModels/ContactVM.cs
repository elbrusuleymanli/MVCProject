using MVCProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.ViewModels
{
    public class ContactVM
    {
        public List<ContactBanner> ContactBanners { get; set; }
        public List<ContactAdress> ContactAdresses { get; set; }
    }
}
