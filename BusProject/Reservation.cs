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
        private void Reservation_Load(object sender, EventArgs e)
        {
 
            using (BusProjectEntities con = new BusProjectEntities())
            {
                routeBindingSource2.DataSource = con.Routes.ToList();
                Route obj = cbStartLocation.SelectedItem as Route;
                if (obj != null)
                    routeBindingSource2.DataSource = con.Routes.Where(p => p.RouteId == obj.RouteId).ToList();
            }

        }
        private void cbStartLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Route obj = cbStartLocation.SelectedItem as Route;
            if (obj != null)
            {
                using (BusProjectEntities con = new BusProjectEntities())
                {
                    routeBindingSource2.DataSource = con.Routes.Where(p => p.RouteId == obj.RouteId).ToList();
                }
            }
        }
    }
}
