
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BttSearch = new System.Windows.Forms.Button();
            this.checkPremium = new System.Windows.Forms.CheckBox();
            this.checkEconomy = new System.Windows.Forms.CheckBox();
            this.checkHighClass = new System.Windows.Forms.CheckBox();
            this.DepartureDate = new System.Windows.Forms.DateTimePicker();
            this.cbDeparture = new System.Windows.Forms.ComboBox();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.cbArrival = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BttBack = new System.Windows.Forms.Button();
            this.BttNext = new System.Windows.Forms.Button();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(36, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착지";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 205);
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
            this.groupBox1.Controls.Add(this.checkPremium);
            this.groupBox1.Controls.Add(this.checkEconomy);
            this.groupBox1.Controls.Add(this.checkHighClass);
            this.groupBox1.Controls.Add(this.DepartureDate);
            this.groupBox1.Controls.Add(this.cbDeparture);
            this.groupBox1.Controls.Add(this.checkAll);
            this.groupBox1.Controls.Add(this.cbArrival);
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
            this.BttSearch.Location = new System.Drawing.Point(137, 386);
            this.BttSearch.Name = "BttSearch";
            this.BttSearch.Size = new System.Drawing.Size(75, 23);
            this.BttSearch.TabIndex = 9;
            this.BttSearch.Text = "조회";
            this.BttSearch.UseVisualStyleBackColor = true;
            this.BttSearch.Click += new System.EventHandler(this.BttSearch_Click);
            // 
            // checkPremium
            // 
            this.checkPremium.AutoSize = true;
            this.checkPremium.Location = new System.Drawing.Point(253, 296);
            this.checkPremium.Name = "checkPremium";
            this.checkPremium.Size = new System.Drawing.Size(89, 19);
            this.checkPremium.TabIndex = 8;
            this.checkPremium.Text = "프리미엄";
            this.checkPremium.UseVisualStyleBackColor = true;
            this.checkPremium.CheckedChanged += new System.EventHandler(this.checkPremium_CheckedChanged);
            // 
            // checkEconomy
            // 
            this.checkEconomy.AutoSize = true;
            this.checkEconomy.Location = new System.Drawing.Point(253, 344);
            this.checkEconomy.Name = "checkEconomy";
            this.checkEconomy.Size = new System.Drawing.Size(59, 19);
            this.checkEconomy.TabIndex = 8;
            this.checkEconomy.Text = "일반";
            this.checkEconomy.UseVisualStyleBackColor = true;
            // 
            // checkHighClass
            // 
            this.checkHighClass.AutoSize = true;
            this.checkHighClass.Location = new System.Drawing.Point(137, 344);
            this.checkHighClass.Name = "checkHighClass";
            this.checkHighClass.Size = new System.Drawing.Size(59, 19);
            this.checkHighClass.TabIndex = 7;
            this.checkHighClass.Text = "우등";
            this.checkHighClass.UseVisualStyleBackColor = true;
            // 
            // DepartureDate
            // 
            this.DepartureDate.Location = new System.Drawing.Point(132, 198);
            this.DepartureDate.Name = "DepartureDate";
            this.DepartureDate.Size = new System.Drawing.Size(272, 25);
            this.DepartureDate.TabIndex = 3;
            // 
            // cbDeparture
            // 
            this.cbDeparture.DataSource = this.routeBindingSource;
            this.cbDeparture.DisplayMember = "Departure";
            this.cbDeparture.FormattingEnabled = true;
            this.cbDeparture.Location = new System.Drawing.Point(132, 56);
            this.cbDeparture.Name = "cbDeparture";
            this.cbDeparture.Size = new System.Drawing.Size(116, 23);
            this.cbDeparture.TabIndex = 2;
            this.cbDeparture.ValueMember = "Departure";
            this.cbDeparture.SelectedIndexChanged += new System.EventHandler(this.cbDeparture_SelectedIndexChanged);
            this.cbDeparture.SelectionChangeCommitted += new System.EventHandler(this.cbDeparture_SelectedIndexChanged);
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataSource = typeof(BusProject.Data.Route);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(137, 296);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(59, 19);
            this.checkAll.TabIndex = 5;
            this.checkAll.Text = "전체";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.cbDeparture_SelectedIndexChanged);
            // 
            // cbArrival
            // 
            this.cbArrival.DataSource = this.routeBindingSource;
            this.cbArrival.DisplayMember = "Arrival";
            this.cbArrival.FormattingEnabled = true;
            this.cbArrival.Location = new System.Drawing.Point(132, 121);
            this.cbArrival.Name = "cbArrival";
            this.cbArrival.Size = new System.Drawing.Size(116, 23);
            this.cbArrival.TabIndex = 2;
            this.cbArrival.ValueMember = "Arrival";
            this.cbArrival.SelectedIndexChanged += new System.EventHandler(this.cbArrival_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DepartureTime,
            this.ArrivalTime,
            this.operationDateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(485, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(431, 426);
            this.dataGridView1.TabIndex = 5;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataSource = typeof(BusProject.Data.Operation);
            // 
            // BttBack
            // 
            this.BttBack.Location = new System.Drawing.Point(185, 462);
            this.BttBack.Name = "BttBack";
            this.BttBack.Size = new System.Drawing.Size(75, 23);
            this.BttBack.TabIndex = 10;
            this.BttBack.Text = "뒤로가기";
            this.BttBack.UseVisualStyleBackColor = true;
            // 
            // BttNext
            // 
            this.BttNext.Location = new System.Drawing.Point(713, 462);
            this.BttNext.Name = "BttNext";
            this.BttNext.Size = new System.Drawing.Size(75, 23);
            this.BttNext.TabIndex = 11;
            this.BttNext.Text = "다음";
            this.BttNext.UseVisualStyleBackColor = true;
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "출발지";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartureTime.Width = 125;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "도착지";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrivalTime.Width = 125;
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            this.operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            this.operationDateDataGridViewTextBoxColumn.HeaderText = "가는";
            this.operationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            this.operationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 497);
            this.Controls.Add(this.BttNext);
            this.Controls.Add(this.BttBack);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbArrival;
        private System.Windows.Forms.DateTimePicker DepartureDate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BttBack;
        private System.Windows.Forms.Button BttNext;
        private System.Windows.Forms.ComboBox cbDeparture;
        private System.Windows.Forms.CheckBox checkEconomy;
        private System.Windows.Forms.CheckBox checkHighClass;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.CheckBox checkPremium;
        private System.Windows.Forms.Button BttSearch;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
    }
}