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

namespace Bus_Project
{
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
        }
        
        private void bttLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginId.Text != string .Empty && txtLoginPassword.Text != string .Empty)
            {         
                Customer user = Dao.Customer.GetByName(txtLoginId.Text);
                Customer password = Dao.Customer.GetByPassword(txtLoginPassword.Text);

                if (user != null)
                {
                    if (user.LoginPassword == txtLoginPassword.Text)
                        MessageBox.Show("로그인 하세요.");
                    else
                        MessageBox.Show("잘못된 비밀번호입니다.");
                }
                else
                    MessageBox.Show("잘못된 아이디입니다");
            }
            else
                MessageBox.Show("아이디와 비밀번호 입력하세요.");
        }

        private void bttRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();         
      
        }
    }
}
