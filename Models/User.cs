﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class User
    {
        public User()
        {
            Aspnetuserclaims = new HashSet<Aspnetuserclaim>();
            Userlogins = new HashSet<Userlogin>();
            Userroles = new HashSet<Userrole>();
            Usertokens = new HashSet<Usertoken>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string Class { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ResCount { get; set; }

        public virtual ICollection<Aspnetuserclaim> Aspnetuserclaims { get; set; }
        public virtual ICollection<Userlogin> Userlogins { get; set; }
        public virtual ICollection<Userrole> Userroles { get; set; }
        public virtual ICollection<Usertoken> Usertokens { get; set; }
    }
}
