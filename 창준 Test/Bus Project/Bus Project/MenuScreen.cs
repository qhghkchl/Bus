using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bus_Project
{
    public partial class MenuScreen : Form
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void txtReservation_Click(object sender, EventArgs e)
        {
            this.Close();
            Reservation reservation = new Reservation();
            reservation.Show();
        }
    }
}
