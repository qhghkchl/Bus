using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusProject.Data;

namespace BusProject
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }
        private void cbStartLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
/*            Operation user = Dao.Operation.GetArrival(txt);
*/        }
    }
}
