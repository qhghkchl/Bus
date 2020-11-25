
namespace Bus_Project
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
            this.txtReservationInfo = new System.Windows.Forms.Button();
            this.txtReservation = new System.Windows.Forms.Button();
            this.BttMyinfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtReservationInfo);
            this.groupBox1.Controls.Add(this.txtReservation);
            this.groupBox1.Controls.Add(this.BttMyinfo);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(248, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 344);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // txtReservationInfo
            // 
            this.txtReservationInfo.Location = new System.Drawing.Point(104, 258);
            this.txtReservationInfo.Name = "txtReservationInfo";
            this.txtReservationInfo.Size = new System.Drawing.Size(121, 43);
            this.txtReservationInfo.TabIndex = 3;
            this.txtReservationInfo.Text = "예매정보";
            this.txtReservationInfo.UseVisualStyleBackColor = true;
            // 
            // txtReservation
            // 
            this.txtReservation.Location = new System.Drawing.Point(104, 158);
            this.txtReservation.Name = "txtReservation";
            this.txtReservation.Size = new System.Drawing.Size(121, 43);
            this.txtReservation.TabIndex = 2;
            this.txtReservation.Text = "예매하기";
            this.txtReservation.UseVisualStyleBackColor = true;
            this.txtReservation.Click += new System.EventHandler(this.txtReservation_Click);
            // 
            // BttMyinfo
            // 
            this.BttMyinfo.Location = new System.Drawing.Point(104, 57);
            this.BttMyinfo.Name = "BttMyinfo";
            this.BttMyinfo.Size = new System.Drawing.Size(121, 43);
            this.BttMyinfo.TabIndex = 1;
            this.BttMyinfo.Text = "내 정보";
            this.BttMyinfo.UseVisualStyleBackColor = true;
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "MenuScreen";
            this.Text = "MenuScreen";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button txtReservationInfo;
        private System.Windows.Forms.Button txtReservation;
        private System.Windows.Forms.Button BttMyinfo;
    }
}