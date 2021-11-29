using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Vacations.Models;

namespace Vacations.Services
{
    public class DatabaseAccess
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog = Employees;
        Integrated Security = True; Connect Timeout = 30; Encrypt=False;TrustServerCertificate=False;
        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public bool ValidateUser(UserModel user)
        {
            bool sucess = false;

            string sqlStatement = "SELECT * FROM dbo.Employees WHERE [User Name] = @username AND [Password] = @password AND [Is Active] = 'true'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                command.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 40).Value = user.UserName;
                command.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 40).Value = user.Password;

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        sucess = true;
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return sucess;
        }

        public List<VacationsModel> GetVacations()
        {
            List<VacationsModel> vacations = new List<VacationsModel>();

            string sqlStatement = "SELECT [Number Of People], [Destination], [Transport Type]," +
                " [Hotel Stars], [Rooms], [Is Room Free], [Price Of Bed For Adult]," +
                " [Price Of Bed For Children], [Number] FROM dbo.Vacantions";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vacations.Add(new VacationsModel
                        {
                            NumberOfPeople = (int)reader["Number Of People"],
                            Destination = reader["Destination"].ToString(),
                            TransportType = reader["Transport Type"].ToString(),
                            HotelStars = (int)reader["Hotel Stars"],
                            Rooms = reader["Rooms"].ToString(),
                            IsRoomFree = (bool)reader["Is Room Free"],
                            PriceOfBedForAdult = (decimal)reader["Price Of Bed For Adult"],
                            PriceOfBedForChildren = (decimal)reader["Price Of Bed For Children"],
                            Number = (int)reader["Number"]
                        });
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return vacations;
        }
    }
}
