using System;
using System.Collections.Generic;

namespace _3DModels.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;

        public string UserEmail { get; set; } = null!;
        public string UserPassword { get; set; } = null!;

        public string City { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public string Phonenumber { get; set; }
    }
}
