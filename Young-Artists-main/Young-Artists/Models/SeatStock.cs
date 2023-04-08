﻿using System;
using System.Collections.Generic;

namespace Young_Artists.Models
{
    public partial class SeatStock
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public string? Area { get; set; }
        public int? Quantity { get; set; }
        public int? Stock { get; set; }
        public int? Sold { get; set; }
        public decimal? Price { get; set; }
        public bool? IsAvailable { get; set; }
    }
}