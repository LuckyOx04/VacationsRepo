using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vacations.Models
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string EGN { get; set; }
        public string GSM { get; set; }
        public string Email { get; set; }
        public string DateOfEmployment { get; set; }
        public bool IsActive { get; set; }
        public string DateOfRelease { get; set; }
    }
}
