using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace GearShopV2.Models
{
    public class ContactUsViewModel
    {
        public List<ContactUs> Contacts { get; set; }

    }
}

