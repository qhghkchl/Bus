
namespace BusProject.EmployeeUC
{
    partial class ucAddBus
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartLocationE = new System.Windows.Forms.TextBox();
            this.txtArrivalLocationE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtAddBusDate = new System.Windows.Forms.DateTimePicker();
            this.cbAddBusGrade = new System.Windows.Forms.ComboBox();
            this.bttAddBus = new System.Windows.Forms.Button();
            this.bttEditBus = new System.Windows.Forms.Button();
            this.bttDeleteBus = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opeartionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Bus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "출발지";
            // 
            // txtStartLocationE
            // 
            this.txtStartLocationE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Departure", true));
            this.txtStartLocationE.Location = new System.Drawing.Point(141, 80);
            this.txtStartLocationE.Name = "txtStartLocationE";
            this.txtStartLocationE.Size = new System.Drawing.Size(200, 25);
            this.txtStartLocationE.TabIndex = 2;
            this.txtStartLocationE.TextChanged += new System.EventHandler(this.txtStartLocationE_TextChanged);
            // 
            // txtArrivalLocationE
            // 
            this.txtArrivalLocationE.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.routeBindingSource, "Arrival", true));
            this.txtArrivalLocationE.Location = new System.Drawing.Point(141, 132);
            this.txtArrivalLocationE.Name = "txtArrivalLocationE";
            this.txtArrivalLocationE.Size = new System.Drawing.Size(200, 25);
            this.txtArrivalLocationE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "도착지";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "날짜";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "등급";
            // 
            // dtAddBusDate
            // 
            this.dtAddBusDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "OpeartionDate", true));
            this.dtAddBusDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.operationBindingSource, "OpeartionDate", true));
            this.dtAddBusDate.Location = new System.Drawing.Point(141, 193);
            this.dtAddBusDate.Name = "dtAddBusDate";
            this.dtAddBusDate.Size = new System.Drawing.Size(200, 25);
            this.dtAddBusDate.TabIndex = 9;
            // 
            // cbAddBusGrade
            // 
            this.cbAddBusGrade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationBindingSource, "BusType", true));
            this.cbAddBusGrade.FormattingEnabled = true;
            this.cbAddBusGrade.Location = new System.Drawing.Point(141, 315);
            this.cbAddBusGrade.Name = "cbAddBusGrade";
            this.cbAddBusGrade.Size = new System.Drawing.Size(200, 23);
            this.cbAddBusGrade.TabIndex = 10;
            this.cbAddBusGrade.ValueMember = "BusTypeId";
            this.cbAddBusGrade.SelectedIndexChanged += new System.EventHandler(this.cbAddBusGrade_SelectedIndexChanged);
            // 
            // bttAddBus
            // 
            this.bttAddBus.Location = new System.Drawing.Point(45, 385);
            this.bttAddBus.Name = "bttAddBus";
            this.bttAddBus.Size = new System.Drawing.Size(75, 23);
            this.bttAddBus.TabIndex = 11;
            this.bttAddBus.Text = "추가";
            this.bttAddBus.UseVisualStyleBackColor = true;
            this.bttAddBus.Click += new System.EventHandler(this.bttAddBus_Click);
            // 
            // bttEditBus
            // 
            this.bttEditBus.Location = new System.Drawing.Point(176, 385);
            this.bttEditBus.Name = "bttEditBus";
            this.bttEditBus.Size = new System.Drawing.Size(75, 23);
            this.bttEditBus.TabIndex = 12;
            this.bttEditBus.Text = "편집";
            this.bttEditBus.UseVisualStyleBackColor = true;
            this.bttEditBus.Click += new System.EventHandler(this.bttEditBus_Click);
            // 
            // bttDeleteBus
            // 
            this.bttDeleteBus.Location = new System.Drawing.Point(299, 385);
            this.bttDeleteBus.Name = "bttDeleteBus";
            this.bttDeleteBus.Size = new System.Drawing.Size(75, 23);
            this.bttDeleteBus.TabIndex = 13;
            this.bttDeleteBus.Text = "삭제";
            this.bttDeleteBus.UseVisualStyleBackColor = true;
            this.bttDeleteBus.Click += new System.EventHandler(this.bttDeleteBus_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "시간";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 25);
            this.textBox1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.Arrival,
            this.opeartionDateDataGridViewTextBoxColumn,
            this.busTypeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(397, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(675, 430);
            this.dataGridView1.TabIndex = 17;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataSource = typeof(BusProject.Data.Operation);
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 6;
            this.Departure.Name = "Departure";
            this.Departure.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 125;
            // 
            // opeartionDateDataGridViewTextBoxColumn
            // 
            this.opeartionDateDataGridViewTextBoxColumn.DataPropertyName = "OpeartionDate";
            this.opeartionDateDataGridViewTextBoxColumn.HeaderText = "OpeartionDate";
            this.opeartionDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opeartionDateDataGridViewTextBoxColumn.Name = "opeartionDateDataGridViewTextBoxColumn";
            this.opeartionDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // busTypeDataGridViewTextBoxColumn
            // 
            this.busTypeDataGridViewTextBoxColumn.DataPropertyName = "BusType";
            this.busTypeDataGridViewTextBoxColumn.HeaderText = "BusType";
            this.busTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busTypeDataGridViewTextBoxColumn.Name = "busTypeDataGridViewTextBoxColumn";
            this.busTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataSource = typeof(BusProject.Data.Route);
            // 
            // ucAddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bttDeleteBus);
            this.Controls.Add(this.bttEditBus);
            this.Controls.Add(this.bttAddBus);
            this.Controls.Add(this.cbAddBusGrade);
            this.Controls.Add(this.dtAddBusDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtArrivalLocationE);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartLocationE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAddBus";
            this.Size = new System.Drawing.Size(1120, 480);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartLocationE;
        private System.Windows.Forms.TextBox txtArrivalLocationE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtAddBusDate;
        private System.Windows.Forms.ComboBox cbAddBusGrade;
        private System.Windows.Forms.Button bttAddBus;
        private System.Windows.Forms.Button bttEditBus;
        private System.Windows.Forms.Button bttDeleteBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn opeartionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeDataGridViewTextBoxColumn;
    }
}
