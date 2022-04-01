using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Models
{
    public class User:IdentityUser
    {
        
        public string Fullname { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
