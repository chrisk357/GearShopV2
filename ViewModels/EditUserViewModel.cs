﻿using GearShopV2.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GearShopV2.ViewModels
{
    public class EditUserViewModel : IdentityUser
    {


        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter the user name")]
        [Display(Name = "User name")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Please enter the user email")]
        public string Email { get; set; }

        public List<string> UserClaims { get; set; }
        public List<string> identityRole { get; set; }

        [Required(ErrorMessage = "Please enter the birth date")]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}




