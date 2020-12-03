using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.Data.Entities
{
    class Reservation
    {
        // Operation Table
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public DateTime OperationDate { get; set; }
        //public DateTime DepartureTime { get; set; }

        // Route Table
        public int BusTypeId { get; set; }

        // Seat Table
        public string SeatColumn { get; set; }
        public int SeatColumnNumber { get; set; }
        public int PaymentMethod { get; set; }
    }
}
