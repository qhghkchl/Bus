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
using System.Data.SqlClient;

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
            /*bool newVal = (checkAll.Checked == true);
            checkPremium.Checked = newVal;
            checkHigh.Checked = newVal;
            checkEconomy.Checked = newVal;*/

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


        }
        private void bttSearch_Click(object sender, EventArgs e)
        {
            if (comboArrival.Text == "서울")
            {
                reservationTimeBindingSource.DataSource = ReservationTimeDao.GetAllReservationDate();
                reservationTimeBindingSource.Filter = string.Format("ReservationTimeId == 1", comboArrival.SelectedItem.ToString());
            }
            reservationTimeBindingSource.DataSource = ReservationTimeDao.GetAllReservationDate();
            reservationTimeBindingSource.Filter = string.Format("ReservationDate = #{0}#", DateTimePicker.Value.ToLongDateString());
        }
    }
}
