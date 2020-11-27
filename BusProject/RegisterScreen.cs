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
            Customer user = Dao.Customer.GetByName(txtLoginId.Text);
            if (txtLoginId.Text == "" || txtPassword.Text == "" || txtName.Text == "" || txtContact.Text == "" ||txtDateOfBirth.Text == "")
            {
                MessageBox.Show("정보를 입력해주세요.");
            }
            else
            {              
                user.LoginId = txtLoginId.Text.Trim();
                user.LoginPassword = txtPassword.Text.Trim();
                user.Name = txtName.Text.Trim();
                user.PhoneNumber = txtContact.Text.Trim();
                user.Birth = txtDateOfBirth.Text.Trim();

                Dao.Customer.Insert(user);
            }
            this.Clear();
            MessageBox.Show("회원정보 입력완료.");

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
