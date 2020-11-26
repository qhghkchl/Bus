using BusProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusProject.EmployeeUC
{
    public partial class ucAddBus : UserControl
    {
        public ucAddBus()
        {
            InitializeComponent();
        }

        private void cbAddBusGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStartLocationE_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bttAddBus_Click(object sender, EventArgs e)
        {
            routeBindingSource.AddNew();
        }

        private void bttEditBus_Click(object sender, EventArgs e)
        {
            routeBindingSource.EndEdit();
            routeBindingSource.ResetBindings(false);
        }

        private void bttDeleteBus_Click(object sender, EventArgs e)
        {
            routeBindingSource.RemoveCurrent();
        }
    }
}
