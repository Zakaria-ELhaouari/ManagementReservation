using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementReservation.Models
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        public string cause { get; set; }
        public string IdUser { get; set; }
        [ForeignKey(nameof(IdUser))]
        public virtual User User { get; set; }
        public int TypReserve { get; set; }
        [ForeignKey(nameof(TypReserve))]
        public virtual TypeReservation TypeReservation { get; set; }
    }
}
