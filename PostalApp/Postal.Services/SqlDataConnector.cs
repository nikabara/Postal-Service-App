using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Postal.Services;
using Microsoft.Data.SqlClient;

namespace Postal.Services
{
    internal class SqlDataConnector : IDataConnection
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
                                Id = reader.GetByte(0),
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
                                Age = reader.GetByte(3),
                                Email = reader.GetString(4),
                                PhoneNumber = reader.GetString(5),
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
