using System;
using System.Collections.Generic;

#nullable disable

namespace ManagementReservation.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public string Cause { get; set; }

        public int TypeReserveId { get; set; }
        public virtual Typereservation TypeReserve { get; set; }
        public string UserId { get; set; }
        public virtual User User { get; set; }
    }
}
