using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class Role
    {
        public Role()
        {
            Roleclaims = new HashSet<Roleclaim>();
            Userroles = new HashSet<Userrole>();
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }
        public string ConcurrencyStamp { get; set; }

        public virtual ICollection<Roleclaim> Roleclaims { get; set; }
        public virtual ICollection<Userrole> Userroles { get; set; }
    }
}
