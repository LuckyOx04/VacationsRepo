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

        public List<EmployeeModel> GetEmployees()
        {
            return db.GetEmployees();
        }

        public bool IsValid(UserModel user)
        {
            return db.ValidateUser(user);
        }

        public void AddClient(ClientModel client)
        {
            db.AddClient(client);
        }
    }
}
