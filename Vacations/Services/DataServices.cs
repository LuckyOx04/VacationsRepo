using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;

namespace Vacations.Services
{
    public class DataServices
    {
        DatabaseAccess db = new DatabaseAccess();
        public List<VacationsModel> GetVacationData()
        {
            return db.GetVacations();
        }
        public bool IsValid(UserModel user)
        {
            return db.ValidateUser(user);
        }
    }
}
