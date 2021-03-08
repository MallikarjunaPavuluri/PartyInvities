using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvities.Models
{
    public class GuestResponce
    {
        [Required(ErrorMessage = "Please enter yourName")]
        [StringLength(20)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Proper Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enter Proper Phone")]
        [StringLength(10)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Enter Proper Selection")]
        public bool ? WillAttend { get; set; }

    }
}
