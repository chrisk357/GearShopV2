using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GearShopV2.Models
{
    public class ContactUs
    {

        public int Id { get; set; }
        [Required, Display(Name = "Name")]
        public string ContactName { get; set; }
        [Required, Display(Name = "Email")]
        public string ContactEmail { get; set; }
        [Required, Display(Name = "Message"), MaxLength(1024)]
        public string ContactMessage { get; set; }
        [DataType(DataType.Date)]
        public DateTime Posted { get; set; }
        public List<ContactUs> Contacts { get; set; }
    }
}
