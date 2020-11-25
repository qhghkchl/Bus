
namespace Bus_Project
{
    partial class Mainscreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttRegister = new System.Windows.Forms.Button();
            this.bttLogin = new System.Windows.Forms.Button();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttRegister);
            this.groupBox1.Controls.Add(this.bttLogin);
            this.groupBox1.Controls.Add(this.txtLoginPassword);
            this.groupBox1.Controls.Add(this.txtLoginId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(182, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 231);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예매 로그인";
            // 
            // bttRegister
            // 
            this.bttRegister.Location = new System.Drawing.Point(270, 177);
            this.bttRegister.Name = "bttRegister";
            this.bttRegister.Size = new System.Drawing.Size(75, 23);
            this.bttRegister.TabIndex = 3;
            this.bttRegister.Text = "회원가입";
            this.bttRegister.UseVisualStyleBackColor = true;
            this.bttRegister.Click += new System.EventHandler(this.bttRegister_Click);
            // 
            // bttLogin
            // 
            this.bttLogin.Location = new System.Drawing.Point(88, 177);
            this.bttLogin.Name = "bttLogin";
            this.bttLogin.Size = new System.Drawing.Size(75, 23);
            this.bttLogin.TabIndex = 3;
            this.bttLogin.Text = "로그인";
            this.bttLogin.UseVisualStyleBackColor = true;
            this.bttLogin.Click += new System.EventHandler(this.bttLogin_Click);
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(151, 119);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '*';
            this.txtLoginPassword.Size = new System.Drawing.Size(194, 25);
            this.txtLoginPassword.TabIndex = 2;
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(151, 52);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(194, 25);
            this.txtLoginId.TabIndex = 2;
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mainscreen";
            this.Text = "Bus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttRegister;
        private System.Windows.Forms.Button bttLogin;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.TextBox txtLoginId;
    }
}

