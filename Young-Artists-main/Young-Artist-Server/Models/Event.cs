﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Young_Artist_Server.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string EventImage { get; set; }
        public string EventName { get; set; }
        public string EventInfo { get; set; }
        public int? CompanyId { get; set; }
        public string EventSellStartTimestamp { get; set; }
        public string EventSellEndTimestamp { get; set; }
        public string EventStartTimestamp { get; set; }
        public string EventEndTimestamp { get; set; }
        public int? EventTypeId { get; set; }
        public int? EventLocationId { get; set; }
        public bool? EventIsstate { get; set; }
    }
}