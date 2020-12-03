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
            AddInfoIntoComboDeparture();
        }

        private void comboDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddInfoIntoComboArrival();       
        }
        private void bttSearch_Click(object sender, EventArgs e)
        {
            FilterRouteBycationDate();    
        }

        public void ClassCheckbox()
        {
            bool newVal = (checkAll.Checked == true);
            checkPremium.Checked = newVal;
            checkHigh.Checked = newVal;
            checkEconomy.Checked = newVal;
        }
        #region 출발지 / 도착지
        public void AddInfoIntoComboDeparture()
        {
            List<string> cities = Dao.Route.GetDepartureCities();
            foreach (var city in cities)
                comboDeparture.Items.Add(city);
        }
        public void AddInfoIntoComboArrival()
        {
            string departure = (string)comboDeparture.SelectedItem;
            List<string> cities = Dao.Route.GetArrivalCities(departure);
            comboArrival.Items.Clear();
            comboArrival.Items.AddRange(cities.ToArray());
        } 
        #endregion
        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var showdata = DataGridView.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(showdata.ToString());
        }
        public void FilterRouteBycationDate()
        {
            #region 서울 -> 정읍
            if (comboArrival.Text == "서울" && comboDeparture.Text == "정읍")
            {
                var result = from reservationtime in ReservationTimeDao.GetAllReservationDate()
                             from route in RouteDao.GetByRouteId()
                             where reservationtime.RouteId == 1 && route.RouteId == 1 && DateTimePicker.Value.Date == reservationtime.ReservationDate                  
                             select new
                             {
                                 reservationtime.ArrivalTime,
                                 reservationtime.DepartureTime,
                                 reservationtime.ReservationDate,
                                 route.ArrivalLocation,
                                 reservationtime.TravelTime,
                                 reservationtime.RouteId
                             };
               
                    routeBindingSource.DataSource = result;
            }
            #endregion
            #region 대전 -> 부산
            if (comboArrival.Text == "대전" && comboDeparture.Text == "부산")
            {
                var result = from reservationtime in ReservationTimeDao.GetAllReservationDate()
                             from route in RouteDao.GetByRouteId()
                             where reservationtime.RouteId == 2 && route.RouteId == 2 && DateTimePicker.Value.Date == reservationtime.ReservationDate
                             select new
                             {
                                 reservationtime.ArrivalTime,
                                 reservationtime.DepartureTime,
                                 reservationtime.ReservationDate,
                                 route.ArrivalLocation,
                                 reservationtime.TravelTime,
                                 reservationtime.RouteId
                             };
                routeBindingSource.DataSource = result;
            } 
            #endregion
        }

        
    }
}
