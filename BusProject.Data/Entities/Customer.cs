using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.Data
{
    public partial class Customer
    {
        public string ReservationDate { get; set; }
        public int PaymentMethod { get; set; }
        public string OperationDate { get; set; }
        public int DepartureTime { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public int BusTypeId { get; set; }
    }
}
