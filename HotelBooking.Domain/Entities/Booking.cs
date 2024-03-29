﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HotelBooking.Domain.Entities
{
    public class Booking : Entity
    {
        public DateTime Init { get; set; }
        public DateTime Fin { get; set; }
        public int Value { get; set; }
        public int BedroomId { get; set; }
        public int ClientId { get; set; }
    }
}
