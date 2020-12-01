
namespace BusProject
{
    partial class ReservationScreen
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
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDeparture = new System.Windows.Forms.ComboBox();
            this.comboArrival = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.ReservationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArrivalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TravelTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.checkPremium = new System.Windows.Forms.CheckBox();
            this.checkHigh = new System.Windows.Forms.CheckBox();
            this.checkEconomy = new System.Windows.Forms.CheckBox();
            this.bttSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "출발지";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "도착지";
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(157, 212);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(205, 25);
            this.DateTimePicker.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "가는날";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "등급";
            // 
            // comboDeparture
            // 
            this.comboDeparture.FormattingEnabled = true;
            this.comboDeparture.Location = new System.Drawing.Point(157, 44);
            this.comboDeparture.Name = "comboDeparture";
            this.comboDeparture.Size = new System.Drawing.Size(102, 23);
            this.comboDeparture.TabIndex = 5;
            this.comboDeparture.SelectedIndexChanged += new System.EventHandler(this.comboDeparture_SelectedIndexChanged);
            // 
            // comboArrival
            // 
            this.comboArrival.FormattingEnabled = true;
            this.comboArrival.Location = new System.Drawing.Point(157, 127);
            this.comboArrival.Name = "comboArrival";
            this.comboArrival.Size = new System.Drawing.Size(102, 23);
            this.comboArrival.TabIndex = 5;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ReservationDate,
            this.DepartureTime,
            this.ArrivalTime,
            this.TravelTime});
            this.DataGridView.Location = new System.Drawing.Point(454, 30);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 27;
            this.DataGridView.Size = new System.Drawing.Size(547, 339);
            this.DataGridView.TabIndex = 6;
            // 
            // ReservationDate
            // 
            this.ReservationDate.DataPropertyName = "ReservationDate";
            this.ReservationDate.HeaderText = "ReservationDate";
            this.ReservationDate.MinimumWidth = 6;
            this.ReservationDate.Name = "ReservationDate";
            this.ReservationDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ReservationDate.Width = 125;
            // 
            // DepartureTime
            // 
            this.DepartureTime.DataPropertyName = "DepartureTime";
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.MinimumWidth = 6;
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DepartureTime.Width = 125;
            // 
            // ArrivalTime
            // 
            this.ArrivalTime.DataPropertyName = "ArrivalTime";
            this.ArrivalTime.HeaderText = "ArrivalTime";
            this.ArrivalTime.MinimumWidth = 6;
            this.ArrivalTime.Name = "ArrivalTime";
            this.ArrivalTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ArrivalTime.Width = 125;
            // 
            // TravelTime
            // 
            this.TravelTime.DataPropertyName = "TravelTime";
            this.TravelTime.HeaderText = "TravelTime";
            this.TravelTime.MinimumWidth = 6;
            this.TravelTime.Name = "TravelTime";
            this.TravelTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TravelTime.Width = 125;
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(155, 298);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(59, 19);
            this.checkAll.TabIndex = 7;
            this.checkAll.Text = "전체";
            this.checkAll.UseVisualStyleBackColor = true;
            // 
            // checkPremium
            // 
            this.checkPremium.AutoSize = true;
            this.checkPremium.Location = new System.Drawing.Point(277, 298);
            this.checkPremium.Name = "checkPremium";
            this.checkPremium.Size = new System.Drawing.Size(89, 19);
            this.checkPremium.TabIndex = 7;
            this.checkPremium.Text = "프리미엄";
            this.checkPremium.UseVisualStyleBackColor = true;
            // 
            // checkHigh
            // 
            this.checkHigh.AutoSize = true;
            this.checkHigh.Location = new System.Drawing.Point(155, 360);
            this.checkHigh.Name = "checkHigh";
            this.checkHigh.Size = new System.Drawing.Size(59, 19);
            this.checkHigh.TabIndex = 7;
            this.checkHigh.Text = "우등";
            this.checkHigh.UseVisualStyleBackColor = true;
            // 
            // checkEconomy
            // 
            this.checkEconomy.AutoSize = true;
            this.checkEconomy.Location = new System.Drawing.Point(277, 360);
            this.checkEconomy.Name = "checkEconomy";
            this.checkEconomy.Size = new System.Drawing.Size(59, 19);
            this.checkEconomy.TabIndex = 7;
            this.checkEconomy.Text = "일반";
            this.checkEconomy.UseVisualStyleBackColor = true;
            // 
            // bttSearch
            // 
            this.bttSearch.Location = new System.Drawing.Point(155, 415);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(75, 23);
            this.bttSearch.TabIndex = 8;
            this.bttSearch.Text = "조회";
            this.bttSearch.UseVisualStyleBackColor = true;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // ReservationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 450);
            this.Controls.Add(this.bttSearch);
            this.Controls.Add(this.checkEconomy);
            this.Controls.Add(this.checkHigh);
            this.Controls.Add(this.checkPremium);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.comboArrival);
            this.Controls.Add(this.comboDeparture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReservationScreen";
            this.Text = "ReservationScreen";
            this.Load += new System.EventHandler(this.ReservationScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboDeparture;
        private System.Windows.Forms.ComboBox comboArrival;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.CheckBox checkPremium;
        private System.Windows.Forms.CheckBox checkHigh;
        private System.Windows.Forms.CheckBox checkEconomy;
        private System.Windows.Forms.Button bttSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReservationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArrivalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TravelTime;
    }
}