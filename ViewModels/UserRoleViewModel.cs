using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using GearShopV2.Models;
using Microsoft.AspNetCore.Authentication;

namespace GearShopV2.ViewModels
{
    public class UserRoleViewModel
    {
        public UserRoleViewModel()
        {
            Users = new List<IdentityRole>();
        }
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public List<IdentityRole> Users { get; set; }
    }
}
