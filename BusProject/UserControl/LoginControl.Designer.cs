
namespace BusProject
{
    partial class LoginControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.bttLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttRegister
            // 
            this.bttRegister.Location = new System.Drawing.Point(355, 215);
            this.bttRegister.Name = "bttRegister";
            this.bttRegister.Size = new System.Drawing.Size(75, 23);
            this.bttRegister.TabIndex = 8;
            this.bttRegister.Text = "회원가입";
            this.bttRegister.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(236, 90);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(194, 25);
            this.txtLoginId.TabIndex = 6;
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(236, 215);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(75, 23);
            this.bttLogin.TabIndex = 9;
            this.bttLogin.Text = "로그인";
            this.bttLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(236, 157);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(194, 25);
            this.txtLoginPassword.TabIndex = 7;
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bttRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.bttLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoginPassword);
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(654, 342);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLoginPassword;
    }
}
