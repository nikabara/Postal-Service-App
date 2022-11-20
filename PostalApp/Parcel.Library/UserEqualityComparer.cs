

using System.Diagnostics.CodeAnalysis;


namespace Postal.Library
{
    public class UserEqualityComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y) =>
            x.FirstName == y.FirstName &&
                x.LastName == y.LastName &&
                    x.Age == y.Age &&
                        x.Email == y.Email &&
                            x.Password == y.Password;

        public int GetHashCode([DisallowNull] User obj) => 
            obj.FirstName.Length + obj.LastName.Length + obj.Age + obj.Email.Length + obj.Password.Length;
    }
}
