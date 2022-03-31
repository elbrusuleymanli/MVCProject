using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProject.Areas.Admin.ViewModels
{
    public class AddRoleVM
    {
        public List<string> Roles { get; set; }
        public string UserId { get; set; }
        public string RoleName { get; set; }

    }
}
