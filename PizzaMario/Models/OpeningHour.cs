using System;

namespace PizzaMario.Models
{
    public class OpeningHour
    {
        public int Id { get; set; }
        public int Weekday { get; set; }
        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool IsClosed { get; set; }

        public Store Store { get; set; }
    }
}