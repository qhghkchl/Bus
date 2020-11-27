using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusProject.Data
{
    public partial class Operation
    {
        public string Departure { get; set; }
        public string Arrival { get; set; }

        public string BusTypeText
        {
            get
            {
                switch (BusTypeId)
                {
                    case 1:
                        return "프리미엄";
                    case 2:
                        return "우등";
                    case 3:
                        return "일반";
                    default:
                        throw new Exception();
                }
            }
        }

        public int BusTypeId { get; private set; }
    }
}
