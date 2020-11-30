
namespace BusProject
{
    partial class MenuScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bttReservationInfo = new System.Windows.Forms.Button();
            this.bttReservation = new System.Windows.Forms.Button();
            this.bttCustomerInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bttReservationInfo);
            this.groupBox1.Controls.Add(this.bttReservation);
            this.groupBox1.Controls.Add(this.bttCustomerInfo);
            this.groupBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(248, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "매뉴";
            // 
            // bttReservationInfo
            // 
            this.bttReservationInfo.Location = new System.Drawing.Point(104, 258);
            this.bttReservationInfo.Name = "bttReservationInfo";
            this.bttReservationInfo.Size = new System.Drawing.Size(121, 43);
            this.bttReservationInfo.TabIndex = 3;
            this.bttReservationInfo.Text = "예매 내역";
            this.bttReservationInfo.UseVisualStyleBackColor = true;
            this.bttReservationInfo.Click += new System.EventHandler(this.bttReservationInfo_Click);
            // 
            // bttReservation
            // 
            this.bttReservation.Location = new System.Drawing.Point(104, 157);
            this.bttReservation.Name = "bttReservation";
            this.bttReservation.Size = new System.Drawing.Size(121, 43);
            this.bttReservation.TabIndex = 2;
            this.bttReservation.Text = "예매하기";
            this.bttReservation.UseVisualStyleBackColor = true;
            this.bttReservation.Click += new System.EventHandler(this.bttReservation_Click);
            // 
            // bttCustomerInfo
            // 
            this.bttCustomerInfo.Location = new System.Drawing.Point(104, 57);
            this.bttCustomerInfo.Name = "bttCustomerInfo";
            this.bttCustomerInfo.Size = new System.Drawing.Size(121, 43);
            this.bttCustomerInfo.TabIndex = 1;
            this.bttCustomerInfo.Text = "내 정보";
            this.bttCustomerInfo.UseVisualStyleBackColor = true;
            this.bttCustomerInfo.Click += new System.EventHandler(this.bttCustomerInfo_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuScreen";
            this.Text = "매뉴화면";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bttReservationInfo;
        private System.Windows.Forms.Button bttCustomerInfo;
        private System.Windows.Forms.Button bttReservation;
    }
}