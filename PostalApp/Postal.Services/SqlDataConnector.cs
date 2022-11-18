using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;

namespace Postal.Services
{
    public class SqlDataConnector : IDataConnection
    {
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

                    SqlDataReader reader = cmd.ExecuteReader();

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

        public List<Parcel> GetAllParcelsPerUser(User model)
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

                    cmd.Parameters.AddWithValue("@UserId", model.UserId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new Parcel
                            {
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
    }
}
