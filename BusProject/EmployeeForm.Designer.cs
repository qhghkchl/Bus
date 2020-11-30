
namespace BusProject
{
    partial class EmployeeForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.busTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(945, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "운행 관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(937, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "예약 관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.operationDateDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.busTypeTextDataGridViewTextBoxColumn,
            this.busTypeIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(934, 356);
            this.dataGridView1.TabIndex = 0;
            // 
            // operationBindingSource
            // 
            this.operationBindingSource.DataSource = typeof(BusProject.Data.Operation);
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.Width = 125;
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            this.arrivalDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationDateDataGridViewTextBoxColumn
            // 
            this.operationDateDataGridViewTextBoxColumn.DataPropertyName = "OperationDate";
            this.operationDateDataGridViewTextBoxColumn.HeaderText = "OperationDate";
            this.operationDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.operationDateDataGridViewTextBoxColumn.Name = "operationDateDataGridViewTextBoxColumn";
            this.operationDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // busTypeTextDataGridViewTextBoxColumn
            // 
            this.busTypeTextDataGridViewTextBoxColumn.DataPropertyName = "BusTypeText";
            this.busTypeTextDataGridViewTextBoxColumn.HeaderText = "BusTypeText";
            this.busTypeTextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busTypeTextDataGridViewTextBoxColumn.Name = "busTypeTextDataGridViewTextBoxColumn";
            this.busTypeTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.busTypeTextDataGridViewTextBoxColumn.Width = 125;
            // 
            // busTypeIdDataGridViewTextBoxColumn
            // 
            this.busTypeIdDataGridViewTextBoxColumn.DataPropertyName = "BusTypeId";
            this.busTypeIdDataGridViewTextBoxColumn.HeaderText = "BusTypeId";
            this.busTypeIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.busTypeIdDataGridViewTextBoxColumn.Name = "busTypeIdDataGridViewTextBoxColumn";
            this.busTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.busTypeIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 275);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(945, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn busTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}