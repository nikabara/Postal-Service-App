using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;

namespace Postal.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public bool Equal(User x, User y)
        {
            if (x.UserId == y.UserId && x.FirstName == y.FirstName && x.LastName == y.LastName && x.FullName == y.FullName && x.Email == y.Email && x.Password == y.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
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
    }
}