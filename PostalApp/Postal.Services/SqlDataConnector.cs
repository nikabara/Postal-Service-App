using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;
using System.Reflection;

namespace Postal.Services
{
    public class SqlDataConnector : IDataConnection
    {
        /// <summary>
        /// Compares 2 user objects
        /// </summary>
        /// <param name="x">User object 1</param>
        /// <param name="y">User object 2</param>
        /// <returns>bollean if all user obejcts are equal true else false</returns>
        public bool Equal(User x, User y)
        {
            if (x.UserId == y.UserId && x.FirstName == y.FirstName && x.LastName == y.LastName && x.FullName == y.FullName && x.Email == y.Email && x.Password == y.Password)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Gets all parcels ever created from any user
        /// </summary>
        /// <returns>List of parcels from any user ever created</returns>
        public List<Parcel> GetParcels()
        {
            const string sqlExpression = "sp_SelectParcels";
            List<Parcel> result = new List<Parcel>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Parcel
                            {
                                Id = reader.GetInt32(0),
                                UserId = reader.GetInt32(1),
                                ParcelName = reader.GetString(2),
                                ParcelDescription = reader.GetString(3),
                                ParcelPrice = reader.GetInt32(4),
                                SendDate = reader.GetDateTime(5),
                                SentFrom = reader.GetString(6),
                                SentTo = reader.GetString(7),
                                StatusId = reader.GetByte(8),
                                ShippingId = reader.GetByte(9)
                            });
                        }
                    }

                }
                catch (SqlException)
                {

                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Gets shipping id
        /// </summary>
        /// <returns>List of shipping ids (Can be used for statistics)</returns>
        public List<Shipping> GetShipping()
        {
            const string sqlExpression = "sp_SelectShippings";
            List<Shipping> result = new List<Shipping>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Shipping
                            {
                                ShippingId = reader.GetByte(0),
                                ShippingType = reader.GetString(1)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Gets statuses
        /// </summary>
        /// <returns>List of statuses</returns>
        public List<Status> GetStatus()
        {
            const string SqlExpression = "sp_SelectStatus";
            List<Status> result = new List<Status>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new(SqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Status
                            {
                                StatusId = reader.GetByte(0),
                                ParcelStatus = reader.GetString(1)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Gets every user every created
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetUsers()
        {
            const string sqlExpression = "sp_SelectUsers";
            List<User> result = new List<User>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader(); // invalid name phonenumber in sql procedure

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new User
                            {
                                UserId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                FullName = reader.GetString(3),
                                Age = reader.GetByte(4),
                                Email = reader.GetString(5),
                                Password = reader.GetString(6),
                                Balance = reader.GetDouble(7),
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Inserts parcel data into T-SQL data-base
        /// </summary>
        /// <param name="model">Takes Parcel model</param>
        /// <returns>Inserts parcel directly into data-base</returns>
        public Parcel InsertParcel(Parcel model)
        {
            const string sqlExpression = "sp_InsertParcelData";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", model.UserId);
                    cmd.Parameters.AddWithValue("@ParcelName", model.ParcelName);
                    cmd.Parameters.AddWithValue("@ParcelDescription", model.ParcelDescription);
                    cmd.Parameters.AddWithValue("@Delivery", model.Delivery);
                    cmd.Parameters.AddWithValue("@ParcelWeight", model.ParcelWeight);
                    cmd.Parameters.AddWithValue("@ParcelPrice", model.ParcelPrice);
                    cmd.Parameters.AddWithValue("@SendDate", model.SendDate);
                    cmd.Parameters.AddWithValue("@SentFrom", model.SentFrom);
                    cmd.Parameters.AddWithValue("@SentTo", model.SentTo);
                    cmd.Parameters.AddWithValue("@StatusId", model.StatusId);
                    cmd.Parameters.AddWithValue("@ShippingId", model.ShippingId);


                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return model;
        }
        /// <summary>
        /// Inserts user into T-SQL data-base
        /// </summary>
        /// <param name="model">Takes user model</param>
        /// <returns></returns>
        public User InsertUser(User model)
        {
            const string sqlExpression = "sp_InsertUser";

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@Balance", model.Balance);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return model;
        }
        /// <summary>
        /// Gets all parcels per user with given user id
        /// </summary>
        /// <param name="userId">Takes users user id (int)</param>
        /// <returns>Every parcel that user with given user id created</returns>
        public List<Parcel> GetAllParcelsPerUser(int userId)
        {
            const string sqlExpression = "sp_allSpecificUserParcels";
            List<Parcel> result = new List<Parcel>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@UserId", userId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Parcel
                            {
                                UserId = reader.GetInt32(0),
                                ParcelName = reader.GetString(1),
                                ParcelDescription = reader.GetString(2),
                                Delivery = reader.GetBoolean(3),
                                ParcelWeight = reader.GetDouble(4),
                                ParcelPrice = reader.GetDouble(5),
                                SendDate = reader.GetDateTime(6),
                                SentFrom = reader.GetString(7),
                                SentTo = reader.GetString(8),
                                StatusId = reader.GetByte(9),
                                ShippingId = reader.GetByte(10)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }
        }
        /// <summary>
        /// Gets user info with given email and password
        /// </summary>
        /// <param name="email">Takes string email</param>
        /// <param name="password">Takes string password</param>
        /// <returns>User info with given email and password</returns>
        public User GetLoggedInUserInfo(string email, string password)
        {
            const string sqlExpression = "sp_GetLoggedInUserData";
            User result = new User();

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.UserId = reader.GetInt32(0);
                            result.FirstName = reader.GetString(1);
                            result.LastName = reader.GetString(2);
                            result.FullName = reader.GetString(3);
                            result.Age = reader.GetByte(4);
                            result.Email = reader.GetString(5);
                            result.Password = reader.GetString(6);
                            result.Balance = reader.GetDouble(7);
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Gets user info which has entirely equal model with parameter
        /// </summary>
        /// <param name="model">User model</param>
        /// <returns>User</returns>
        public User GetSelectedUser(User model)
        {
            const string sqlExpression = "sp_SelectExactUser";
            User userResult = new User();

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", model.LastName);
                    cmd.Parameters.AddWithValue("@Age", model.Age);
                    cmd.Parameters.AddWithValue("@Email", model.Email);
                    cmd.Parameters.AddWithValue("@Password", model.Password);
                    cmd.Parameters.AddWithValue("@Balance", model.Balance);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            userResult.UserId = reader.GetInt32(0);
                            userResult.FirstName = reader.GetString(1);
                            userResult.LastName = reader.GetString(2);
                            userResult.FullName = reader.GetString(3);
                            userResult.Age = reader.GetByte(4);
                            userResult.Email = reader.GetString(5);
                            userResult.Password = reader.GetString(6);
                            userResult.Balance = reader.GetDouble(7);
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return userResult;
        }
        /// <summary>
        /// Gets basic user with Name,Lastname,Age,Email,Password
        /// </summary>
        /// <returns>List of users</returns>
        public List<User> GetBasicUser()
        {
            const string sqlExpression = "sp_SelectBasicUser";

            List<User> result = new List<User>();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();

                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = cmd.ExecuteReader(); // invalid name phonenumber in sql procedure

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new User
                            {
                                FirstName = reader.GetString(0),
                                LastName = reader.GetString(1),
                                Age = reader.GetByte(2),
                                Email = reader.GetString(3),
                                Password = reader.GetString(4),
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
            return result;
        }
        /// <summary>
        /// Changes users name and lastname in data-base with given email and password
        /// </summary>
        /// <param name="email">Takes email string</param>
        /// <param name="password">Takes password string</param>
        /// <param name="newName">Takes new-name</param>
        /// <param name="newLastName">Takes new-last-name</param>
        /// <returns>Void, directly inserts into data-base</returns>
        public void AlterUser(string email, string password, string newName, string newLastName)
        {
            const string sqlExpression = "sp_AlterUser";

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@FirstName", newName);
                    cmd.Parameters.AddWithValue("@LastName", newLastName);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// Performs money transactions on user balance with given email
        /// </summary>
        /// <param name="email">Takes email string</param>
        /// <param name="moneyAmmount">Takes money ammount double</param>
        /// <returns>Void, directly changes balance in data-base</returns>
        public void MoneyTransaction(string email, double moneyAmmount)
        {
            const string sqlExpression = "sp_CommitMoneyTransaction";

            using (SqlConnection connection = new SqlConnection(GlobalConfig.ConnectionString()))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new(sqlExpression, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@MoneyAmmount", moneyAmmount);

                    cmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}