using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class Usertoken
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string LoginProvider { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public virtual User User { get; set; }
    }
}
