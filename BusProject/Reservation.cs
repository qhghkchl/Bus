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
            using (BusProjectEntities con = new BusProjectEntities())  // 출발지, 도착지 데이터베이스에 연결 및 list형식으로 뛰우기
            {
                routeBindingSource.DataSource = con.Routes.ToList();
            }

        }

        private void cbDeparture_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool newVal = (checkAll.Checked == true);
            checkPremium.Checked = newVal;
            checkHighClass.Checked = newVal;
            checkEconomy.Checked = newVal;
        }
        private void cbArrival_SelectedIndexChanged(object sender, EventArgs e)
        {           
        }
        private void checkPremium_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Do_Checked()
        {
            BttSearch.Enabled = checkPremium.Checked;
        }

        private void BttSearch_Click(object sender, EventArgs e)
        {
            #region 출발지 조건을 데이터테이블에 전달
            Route depart = cbDeparture.SelectedItem as Route;

            if (depart != null)
            {
                using (BusProjectEntities con = new BusProjectEntities())
                {
                    operationBindingSource.DataSource = con.Operations.Where(p => p.RouteId == depart.RouteId).ToList();
                }

            }

            #endregion
            #region 도착지 조건을 데이터테이블에 전달
            Route arrival = cbArrival.SelectedItem as Route;

            if (arrival != null)
            {
                using (BusProjectEntities con = new BusProjectEntities())
                {
                    operationBindingSource.DataSource = con.Operations.Where(a => a.RouteId == arrival.RouteId).ToList();
                }
            } 
            #endregion
        }

    }


}

