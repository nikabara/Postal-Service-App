﻿namespace Postal.Library
{
    public class User
    {
        public int UserId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName { get; set; }
        public byte Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

        public override bool Equals(object obj) => new UserEqualityComparer().Equals(obj);
        public override int GetHashCode() => new UserEqualityComparer().GetHashCode();
    }
}
