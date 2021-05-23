using System;

namespace Data.Entities
{
    public class User
    {
        public long UserId { get; set; }

        public DateTime RegistrationDate { get; set; }
        
        public DateTime LastActivityDate { get; set; }
    }
}