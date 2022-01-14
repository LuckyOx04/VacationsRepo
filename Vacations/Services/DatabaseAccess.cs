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

        public List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            string sqlStatement = "SELECT [Name], [Second Name]," +
                " [Last Name], [EGN], [GSM], [Email], [Date Of Employment]," +
                " [Is Active], [Date Of Release] FROM dbo.Employees";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(sqlStatement, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        employees.Add(new EmployeeModel
                        {
                            FirstName = reader["Name"].ToString(),
                            SecondName = reader["Second Name"].ToString(),
                            LastName = reader["Last Name"].ToString(),
                            EGN = reader["EGN"].ToString(),
                            GSM = reader["GSM"].ToString(),
                            Email = reader["Email"].ToString(),
                            DateOfEmployment = reader["Date Of Employment"].ToString(),
                            IsActive = (bool)reader["Is Active"],
                            DateOfRelease = reader["Date Of Release"].ToString()
                        });
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return employees;
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

        public bool AddClient(ClientModel client)
        {
            bool success = false;

            string sqlStatement = " INSERT INTO dbo.Clients ([First Name], [Last Name], [GSM], [Email], [Is Mature])" +
                " VALUES (@_FirstName, @_LastName, @_GSM, @_Email, @_IsMature)";
            string sqlStatement2 = "SELECT COUNT(*) FROM dbo.Clients WHERE [Email] = @checkEmail";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand checkCommand = new SqlCommand(sqlStatement2, connection);
                checkCommand.Parameters.AddWithValue("@checkEmail", client.Email);
                connection.Open();
                int userExists = (int)checkCommand.ExecuteScalar();
                if (userExists == 0)
                {
                    success = true;

                    SqlCommand command = new SqlCommand(sqlStatement, connection);

                    command.Parameters.Add("@_FirstName", System.Data.SqlDbType.VarChar, 50).Value = client.FirstName;
                    command.Parameters.Add("@_LastName", System.Data.SqlDbType.VarChar, 50).Value = client.LastName;
                    command.Parameters.Add("@_GSM", System.Data.SqlDbType.VarChar, 10).Value = client.GSM;
                    command.Parameters.Add("@_Email", System.Data.SqlDbType.VarChar, 50).Value = client.Email;
                    command.Parameters.Add("@_IsMature", System.Data.SqlDbType.Bit).Value = client.IsMature;

                    try
                    {
                        command.ExecuteNonQuery();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
            return success;
        }
    }
}
