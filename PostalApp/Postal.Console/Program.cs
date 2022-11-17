using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;
using Postal.Services;

SqlDataConnector CSC = new SqlDataConnector();



//CSC.InsertUser(new User
//{
//    FirstName= "მარიკა",
//    LastName = "გახოკია",
//    Age = 30,
//    Email = "marikagakhokia@yahoo.com",
//    PhoneNumber = "577565421"
//});

//Console.WriteLine("Status : ");
//string status = Console.ReadLine();
//byte status_num = 0;
//Console.WriteLine("Shipping Method : ");
//string sm = Console.ReadLine();
//byte sm_num = 0;

//if (status == "Packing")
//{
//    status_num = 1;
//} else if (status == "Sent")
//{
//    status_num= 2;
//} else if (status == "Delivered")
//{
//    status_num = 3;
//} else if (status == "Ready")
//{
//    status_num = 4;
//}

//if (sm == "Air")
//{
//    sm_num = 1;
//} else if (sm == "Ground")
//{
//    sm_num = 2;
//} else if (sm == "Marine")
//{
//    sm_num = 3;
//}

//CSC.InsertParcel(new Parcel
//{
//    UserId = 1,
//    ParcelName = "testparcelfromCS",
//    ParcelDescription = "DescriptionFromCS",
//    ParcelPrice = 500,
//    SendDate = DateTime.Now,
//    SentFrom = "Georgia",
//    SentTo = "USA",
//    StatusId = status_num,
//    ShippingId = sm_num,
//});
