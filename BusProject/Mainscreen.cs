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
    public partial class Mainscreen : Form
    {
        public Mainscreen()
        {
            InitializeComponent();
        }
        // Menuscreen 폼으로 이동하기 위한 변수 생성 
        MenuScreen menuScreen = new MenuScreen();
        private void bttLogin_Click(object sender, EventArgs e)
        {
            // 관리자 폼으로 로그인

            if (rbttAdmin.Checked)
            {
                if (txtLoginId.Text == "admin" && txtLoginPassword.Text == "3512")
                {
                    EmployeeForm employeeForm = new EmployeeForm();
                    this.Hide();
                    employeeForm.Show();
                }
            }           
            else
            {
                if (txtLoginId.Text != string.Empty && txtLoginPassword.Text != string.Empty)
                {                  
                    Customer user = Dao.Customer.GetByLogid(txtLoginId.Text);

                    if (user != null)
                    {
                        if (user.LoginPassword == txtLoginPassword.Text)
                        {
                            MessageBox.Show("로그인이 되었습니다.");
                            this.Hide();
                            menuScreen.Show();
                        }
                        else
                            MessageBox.Show("잘못된 비밀번호입니다.");
                    }
                    else
                        MessageBox.Show("잘못된 아이디입니다");
                }
                else
                    MessageBox.Show("아이디와 비밀번호 입력하세요.");
            }
        }

        private void bttRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterScreen register = new RegisterScreen();
            register.Show();
        }
        private void txtLoginPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttLogin_Click(sender, e);
                bttLogin.Select();
            }
        }
    }
}
