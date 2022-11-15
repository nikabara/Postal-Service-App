using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;
using Postal.Services;

SqlDataConnector CSC = new SqlDataConnector();

var result = CSC.GetUsers();

Console.ReadLine();