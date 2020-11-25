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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        Bus_ProjectEntities con = new Bus_ProjectEntities();
        private void bttLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != string .Empty && txtPassword.Text != string .Empty)
            {
                var user = con.Customers.Where(a => a.Username.Equals(txtUsername.Text)).SingleOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(txtPassword.Text))
                    {
                        MessageBox.Show("로그인 하세요.");
                    }
                    else
                    {
                        MessageBox.Show("잘못된 비밀번호입니다.");
                    }
                }
                else
                {
                    MessageBox.Show("잘못된 아이디입니다");
                }
            }
            else
            {
                MessageBox.Show("아이디와 비밀번호 입력하세요.");
            }      
        }

        private void bttRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();         
      
        }
    }
}
