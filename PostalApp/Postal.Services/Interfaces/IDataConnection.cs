using Postal.Library;

namespace Postal.Services.Interfaces
{
    internal interface IDataConnection
    {
        public bool Equal(User x, User y);
        public List<Parcel> GetParcels();
        public List<Shipping> GetShipping();
        public List<Status> GetStatus();
        public List<User> GetUsers();
        public List<User> GetBasicUser();
        public Parcel InsertParcel(Parcel model);
        public User InsertUser(User model);
        public User GetLoggedInUserInfo(string email, string password);
        public List<Parcel> GetAllParcelsPerUser(User model);
        public User GetSelectedUser(User model);
    }
}
