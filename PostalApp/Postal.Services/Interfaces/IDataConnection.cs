using Postal.Library;

namespace Postal.Services.Interfaces
{
    internal interface IDataConnection
    {
        public List<Parcel> GetParcels();
        public List<Shipping> GetShipping();
        public List<Status> GetStatus();
        public List<User> GetUsers();
    }
}
