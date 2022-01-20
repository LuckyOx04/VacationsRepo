using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class EmployeeModel
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Second Name")]
        public string SecondName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        [DisplayName("Date Of Employment")]
        public string DateOfEmployment { get; set; }
        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
        [DisplayName("Date Of Release")]
        public string DateOfRelease { get; set; }
    }
}
