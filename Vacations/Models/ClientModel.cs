﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class ClientModel
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [DisplayName("Telephone Number")] 
        public string GSM { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [DisplayName("Are you mature?")]
        public bool IsMature { get; set; }
    }
}
