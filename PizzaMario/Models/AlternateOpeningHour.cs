﻿using System;
using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class AlternateOpeningHour
    {
        public int Id { get; set; }
        public int Weekday { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool IsClosed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}