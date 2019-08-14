using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations;

namespace GearShopV2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime Birthdate { get; set; }
        public string City { get; set; }
        public string State { get; set; }


        //
        //------------------------------------------
        // ------------------------------------
        //Just to see if it would work correctly Added postal code with displayaddress
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        public string DisplayAddress
        {
            get
            {
                string dspCity =
                    string.IsNullOrWhiteSpace(this.City) ? "" : this.City;
                string dspState =
                    string.IsNullOrWhiteSpace(this.State) ? "" : this.State;
                string dspPostalCode =
                    string.IsNullOrWhiteSpace(this.PostalCode) ? "" : this.PostalCode;

                return string
                    .Format("{0} {1} {2}", dspCity, dspState, dspPostalCode);
            }
        }


        //-------------------------------------------------------
        //Added below becuase of microsofot doc under section 
        //Add IdentityUser POCO navigation properties
        public virtual ICollection<IdentityUserRole<int>>  Roles { get; } = new List<IdentityUserRole<int>>();
        public virtual ICollection<IdentityUserClaim<int>> Claims { get; } = new List<IdentityUserClaim<int>>();
        public virtual ICollection<IdentityUserLogin<int>> Logins { get; } = new List<IdentityUserLogin<int>>();


    }


}
