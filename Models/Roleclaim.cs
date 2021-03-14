﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class Roleclaim
    {
        public int Id { get; set; }
        public string RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }

        public virtual Role Role { get; set; }
    }
}
