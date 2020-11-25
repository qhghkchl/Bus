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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        
        MenuScreen mainmenu = new MenuScreen();
        
        private void bttConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtBirthday.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("정보를 입력해주세요.");
            }
            else
            {
                Customer customer = new Customer();
                customer.Name = txtName.Text.Trim();
                //TODO : 수정
                // customer.PhoneNumber = txtPhone.Text.Trim();
                customer.Birth = int.Parse(txtBirthday.Text);
                customer.LoginId = txtUsername.Text.Trim();
                customer.LoginPassword = txtPassword.Text.Trim();

                Dao.Customer.Insert(customer);

                Clear();
                MessageBox.Show("회원정보 입력완료.");
                this.Close();
                mainmenu.Show();
            }           
        }
        private void BttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mainscreen mainscreen = new Mainscreen();
            mainscreen.Show();
            
        }
        void Clear()
        {
            txtName.Text = txtPhone.Text = txtBirthday.Text = txtPassword.Text = txtUsername.Text = "";
        }
    }
}
