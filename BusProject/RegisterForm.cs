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
            if (txtName.Text == "" || txtPhone.Text == "" || txtBirthday.Text == "" || txtLoginPassword.Text == "" || txtLoginId.Text == "")
            {
                MessageBox.Show("정보를 입력해주세요.");
            }
            else
            {
                Customer user = Dao.Customer.GetByName(txtLoginId.Text);

                user.Name = txtName.Text.Trim();             
                user.PhoneNumber = txtPhone.Text.Trim();
                user.Birth = txtBirthday.Text.Trim();
                user.LoginId = txtLoginId.Text.Trim();
                user.LoginPassword = txtLoginPassword.Text.Trim();

                Dao.Customer.Insert(user);

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
            txtName.Text = txtPhone.Text = txtBirthday.Text = txtLoginPassword.Text = txtLoginId.Text = "";
        }
    }
}
