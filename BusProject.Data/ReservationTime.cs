//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BusProject.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReservationTime
    {
        public int ReservationTimeId { get; set; }
        public int RouteId { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public System.TimeSpan DepartureTime { get; set; }
        public System.TimeSpan ArrivalTime { get; set; }
        public System.TimeSpan TravelTime { get; set; }
    
        public virtual Route Route { get; set; }
    }
}
