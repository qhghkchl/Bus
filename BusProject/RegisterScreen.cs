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
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }
        private void BttRegistrationComplete_Click(object sender, EventArgs e)
        {
            Customer userval = new Customer();
            if (txtLoginId.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtContact.Text == "" ||txtDateOfBirth.Text == "")
            {
                MessageBox.Show("정보를 입력해주세요.");
                return;
            }        
            else if (userval != null)
            {             
                userval.LoginId = txtLoginId.Text.Trim();
                userval.LoginPassword = txtPassword.Text.Trim();
                userval.Name = txtName.Text.Trim();
                userval.PhoneNumber = txtContact.Text.Trim();
                userval.DateOfBirth = txtDateOfBirth.Text.Trim();

                Dao.Customer.Insert(userval);
                this.Clear();
                MessageBox.Show("회원정보 입력완료.");
            }

            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            this.Close();
        }
        private void Clear()
        {
            txtLoginId.Text = txtPassword.Text = txtName.Text = txtContact.Text = txtDateOfBirth.Text = "";
        }
    }
}
