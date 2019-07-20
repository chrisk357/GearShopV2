using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GearShopV2.Models
{
    public class ContactUs
    {
        public int Id { get; set; }
        public string contactName { get; set; }
        public string contactEmail { get; set; }
        public string contactMessage { get; set; }
        public DateTime Posted { get; set; }


    }
}
