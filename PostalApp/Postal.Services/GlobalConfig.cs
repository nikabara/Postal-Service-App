namespace Postal.Services
{
    internal class GlobalConfig
    {
        public static string ConnectionString()
        {
            return @"Server=DESKTOP-N93AKIG\SQLEXPRESS;Database=PostalServiceApp;Trusted_Connection=true;TrustServerCertificate=true";
        }
    }
}
