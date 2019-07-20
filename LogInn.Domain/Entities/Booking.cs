using System;
using System.Collections.Generic;
using System.Text;

namespace LogInn.Domain.Entities
{
    class Booking
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Booking(DateTime checkin, DateTime checkout)
        {
            this.CheckIn = checkin;
            this.CheckOut = checkout;
        }
    }
}
