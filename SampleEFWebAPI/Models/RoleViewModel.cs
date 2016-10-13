using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleEFWebAPI.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class AddToRoleViewModel
    {
        public string UserId { get; set; }
        public string RoleName { get; set; }
    }
}