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

namespace BusProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        string username;
        public EmployeeForm(string s)
        {
            InitializeComponent();
            username = s; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            dgvManOperation.DataSource = Dao.Operation.GetAll();
            dgvManOperation.DataSource = Dao.Route.GetAll();

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            base.OnLoad(e);
            dgvManOperation.DataSource = Dao.Operation.GetAll();
            dgvManOperation.DataSource = Dao.Route.GetAll();

        }
    }
}
