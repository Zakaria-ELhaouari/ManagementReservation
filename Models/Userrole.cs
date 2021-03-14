﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class Userrole
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
