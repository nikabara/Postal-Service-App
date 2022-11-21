using System.Data;
using Postal.Services.Interfaces;
using Postal.Library;
using Microsoft.Data.SqlClient;
using Postal.Services;

//CSC.InsertUser(new User
//{
//    FirstName= "მარიკა",
//    LastName = "გახოკია",
//    Age = 30,
//    Email = "marikagakhokia@yahoo.com",
//    Password = "Step2019"
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

//var result1 = CSC.GetAllParcelsPerUser(new User
//{
//    UserId = 1
//});

//var result2 = CSC.GetAllParcelsPerUser(new User
//{
//    UserId = 3
//});

//Console.ReadLine();

//SqlDataConnector CSC = new SqlDataConnector();


//List<string> strings1 = new() {"nika","baratashvili","nikobar3005@gmail.com","Step2019"};
//List<string> strings2 = new() {"nika","baratashvili","nikobar3005@gmail.com","Step2019"};

//bool result = strings1.SequenceEqual(strings2);

//string gottenEmail = CSC.GetLoggedInUserInfo("baratashvilinick@gmail.com", "Step2019").Email;
//string gottenPassword = CSC.GetLoggedInUserInfo("baratashvilinick@gmail.com", "Step2019").Password;

//bool resultat = false;
//if (gottenEmail == "baratashvilinick@gmail.com" && gottenPassword == "Step2019")
//{
//    resultat = true;
//}
//else
//{
//    resultat = false;
//}

//Console.ReadKey();


//SqlDataConnector sqlCon = new SqlDataConnector();

//List<User> myUser = new List<User>()
//{
//    new User()
//    {
//        UserId = 1,
//        FirstName = "ნიკა",
//        LastName = "ბარათაშვილი",
//        FullName = $"ნიკა ბარათაშვილი",
//        Age = 15,
//        Email = "baratashvilinick@gmail.com",
//        Password = "Step2019"
//    },
//    new User()
//    {
//        UserId = 3,
//        FirstName = "marika",
//        LastName = "gaxokia",
//        FullName = $"marika gaxokia",
//        Age = 45,
//        Email = "marikagaxokia@gmail.com",
//        Password = "skdfjd55"
//    }
//};

var mynewuser = new User
{
    FirstName = "ნიკა",
    LastName = "ბარათაშვილი",
    Age = 15,
    Email = "baratashvilinick@gmail.com",
    Password = "Step2019"
};

//var gottenUser = sqlCon.GetUsers();

//bool equal = gottenUser.Equals(myUser);

SqlDataConnector sqlCon = new SqlDataConnector();

bool ifEquals = sqlCon.GetBasicUser().Any(x => sqlCon.Equal(x, mynewuser));

Console.ReadKey();