using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusProject.Data;

namespace BusProject
{
    public partial class ReservationScreen : Form
    {
        public ReservationScreen()
        {
            InitializeComponent();
        }

        private void ReservationScreen_Load(object sender, EventArgs e)
        {
            List<string> cities = Dao.Route.GetDepartureCities();
            foreach (var city in cities)
            comboDeparture.Items.Add(city);
        }

        private void comboDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            string departure = (string)comboDeparture.SelectedItem;
            List<string> cities = Dao.Route.GetArrivalCities(departure);
            comboArrival.Items.Clear();
            comboArrival.Items.AddRange(cities.ToArray());

            // 수정중 
            /*operationBindingSource.DataSource = OperationDao.GetAllOperation();
            operationBindingSource.Filter = string.Format("OperationDate = #{0}#", PickDate.Value.ToShortDateString());*/
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            // 수정중 
            /*operationBindingSource.DataSource = OperationDao.GetAllOperation();
            operationBindingSource.Filter = string.Format("OperationDate = #{0}#", PickDate.Value.ToLongDateString());*/
        }
    }
}
