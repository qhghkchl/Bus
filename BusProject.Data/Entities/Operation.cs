using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.Data
{
    public partial class Operation
    {
        public string DepartureLocation { get; set; }
        public string ArrivalLocation { get; set; }
        public int BusTypeId { get; set; }
    }
}
