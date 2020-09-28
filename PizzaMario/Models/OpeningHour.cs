using System;
using System.Collections.Generic;

namespace PizzaMario.Models
{
    public class OpeningHour
    {
        public int Id { get; set; }

        // TODO: BaseClass met string ID
        public int Weekday { get; set; }

        public DateTime OpeningTime { get; set; }
        public DateTime ClosingTime { get; set; }
        public bool IsClosed { get; set; }

        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}