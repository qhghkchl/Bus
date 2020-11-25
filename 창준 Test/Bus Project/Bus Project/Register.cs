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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        Customer CustomerInfo = new Customer();
        MenuScreen mainmenu = new MenuScreen();
        private void bttConfirm_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtPhone.Text == "" || txtBirthday.Text == "" || txtPassword.Text == "" || txtUsername.Text == "")
            {
                MessageBox.Show("정보를 입력해주세요.");
            }
            else
            {
                using (Bus_ProjectEntities con = new Bus_ProjectEntities())
                {
                    CustomerInfo.Name = txtName.Text.Trim();
                    CustomerInfo.PhoneNumber = txtPhone.Text.Trim();
                    CustomerInfo.Birth = txtBirthday.Text.Trim();
                    CustomerInfo.Username = txtUsername.Text.Trim();
                    CustomerInfo.Password = txtPassword.Text.Trim();
                    con.Customers.Add(CustomerInfo);
                    con.SaveChanges();

                }

                Clear();
                MessageBox.Show("회원정보 입력완료.");
                this.Close();
                mainmenu.Show();
            }           
        }
        private void BttBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainscreen = new Main();
            mainscreen.Show();
            
        }
        void Clear()
        {
            txtName.Text = txtPhone.Text = txtBirthday.Text = txtPassword.Text = txtUsername.Text = "";
        }
    }
}
