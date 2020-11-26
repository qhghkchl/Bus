
namespace BusProject
{
    partial class Reservation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BttSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.checkEconomy = new System.Windows.Forms.CheckBox();
            this.checkPremium = new System.Windows.Forms.CheckBox();
            this.checkHighClass = new System.Windows.Forms.CheckBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.cbStartTime = new System.Windows.Forms.ComboBox();
            this.cbArrivalLocation = new System.Windows.Forms.ComboBox();
            this.cbStartLocation = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BttBack = new System.Windows.Forms.Button();
            this.BttNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "가는날";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "등급";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BttSearch);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DepartureDate);
            this.groupBox1.Controls.Add(this.checkEconomy);
            this.groupBox1.Controls.Add(this.checkPremium);
            this.groupBox1.Controls.Add(this.checkHighClass);
            this.groupBox1.Controls.Add(this.checkAll);
            this.groupBox1.Controls.Add(this.cbStartTime);
            this.groupBox1.Controls.Add(this.cbArrivalLocation);
            this.groupBox1.Controls.Add(this.cbStartLocation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "예매하기";
            // 
            // BttSearch
            // 
            this.BttSearch.Location = new System.Drawing.Point(173, 397);
            this.BttSearch.Name = "BttSearch";
            this.BttSearch.Size = new System.Drawing.Size(75, 23);
            this.BttSearch.TabIndex = 9;
            this.BttSearch.Text = "조회";
            this.BttSearch.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "시간";
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(132, 161);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(272, 25);
            this.DepartureDate.TabIndex = 3;
            // 
            // checkEconomy
            // 
            this.checkEconomy.AutoSize = true;
            this.checkEconomy.Location = new System.Drawing.Point(257, 353);
            this.checkEconomy.Name = "checkEconomy";
            this.checkEconomy.Size = new System.Drawing.Size(59, 19);
            this.checkEconomy.TabIndex = 8;
            this.checkEconomy.Text = "일반";
            this.checkEconomy.UseVisualStyleBackColor = true;
            // 
            // checkPremium
            // 
            this.checkPremium.AutoSize = true;
            this.checkPremium.Location = new System.Drawing.Point(257, 292);
            this.checkPremium.Name = "checkPremium";
            this.checkPremium.Size = new System.Drawing.Size(89, 19);
            this.checkPremium.TabIndex = 6;
            this.checkPremium.Text = "프리미엄";
            this.checkPremium.UseVisualStyleBackColor = true;
            // 
            // checkHighClass
            // 
            this.checkHighClass.AutoSize = true;
            this.checkHighClass.Location = new System.Drawing.Point(132, 353);
            this.checkHighClass.Name = "checkHighClass";
            this.checkHighClass.Size = new System.Drawing.Size(59, 19);
            this.checkHighClass.TabIndex = 7;
            this.checkHighClass.Text = "우등";
            this.checkHighClass.UseVisualStyleBackColor = true;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(132, 292);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(59, 19);
            this.checkAll.TabIndex = 5;
            this.checkAll.Text = "전체";
            this.checkAll.UseVisualStyleBackColor = true;
            // 
            // cbStartTime
            // 
            this.cbStartTime.FormattingEnabled = true;
            this.cbStartTime.Location = new System.Drawing.Point(132, 214);
            this.cbStartTime.Name = "cbStartTime";
            this.cbStartTime.Size = new System.Drawing.Size(116, 23);
            this.cbStartTime.TabIndex = 4;
            // 
            // cbArrivalLocation
            // 
            this.cbArrivalLocation.FormattingEnabled = true;
            this.cbArrivalLocation.Location = new System.Drawing.Point(132, 103);
            this.cbArrivalLocation.Name = "cbArrivalLocation";
            this.cbArrivalLocation.Size = new System.Drawing.Size(116, 23);
            this.cbArrivalLocation.TabIndex = 2;
            // 
            // cbStartLocation
            // 
            this.cbStartLocation.FormattingEnabled = true;
            this.cbStartLocation.Location = new System.Drawing.Point(132, 51);
            this.cbStartLocation.Name = "cbStartLocation";
            this.cbStartLocation.Size = new System.Drawing.Size(116, 23);
            this.cbStartLocation.TabIndex = 1;
            this.cbStartLocation.SelectedIndexChanged += new System.EventHandler(this.cbStartLocation_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(485, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(472, 426);
            this.dataGridView1.TabIndex = 5;
            // 
            // BttBack
            // 
            this.BttBack.Location = new System.Drawing.Point(144, 462);
            this.BttBack.Name = "BttBack";
            this.BttBack.Size = new System.Drawing.Size(75, 23);
            this.BttBack.TabIndex = 10;
            this.BttBack.Text = "뒤로가기";
            this.BttBack.UseVisualStyleBackColor = true;
            // 
            // BttNext
            // 
            this.BttNext.Location = new System.Drawing.Point(777, 462);
            this.BttNext.Name = "BttNext";
            this.BttNext.Size = new System.Drawing.Size(75, 23);
            this.BttNext.TabIndex = 11;
            this.BttNext.Text = "다음";
            this.BttNext.UseVisualStyleBackColor = true;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 497);
            this.Controls.Add(this.BttNext);
            this.Controls.Add(this.BttBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbStartTime;
        private System.Windows.Forms.ComboBox cbArrivalLocation;
        private System.Windows.Forms.ComboBox cbStartLocation;
        private System.Windows.Forms.CheckBox checkEconomy;
        private System.Windows.Forms.CheckBox checkPremium;
        private System.Windows.Forms.CheckBox checkHighClass;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttBack;
        private System.Windows.Forms.Button BttNext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BttSearch;
    }
}