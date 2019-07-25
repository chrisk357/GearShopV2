using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class ContactUs
    {
        
        public int Id { get; set; }
        [Required, Display(Name = "Name")]
        public string contactName { get; set; }
        [Required, Display(Name = "Email")]
        public string contactEmail { get; set; }
        [Required, Display(Name = "Message"), MaxLength(1024)]
        public string contactMessage { get; set; }
        [DataType(DataType.Date)]
        public DateTime Posted { get; set; }
        public List<ContactUs> Contacts { get; set; }
    }
}
