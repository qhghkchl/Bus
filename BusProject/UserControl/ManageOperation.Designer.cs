
namespace BusProject.User_Control
{
    partial class AddBusControl
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BusTypeText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.operationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(596, 406);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(714, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departureDataGridViewTextBoxColumn,
            this.BusTypeText,
            this.arrivalDataGridViewTextBoxColumn,
            this.operationDateDataGridViewTextBoxColumn,
            this.arrivalTimeDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.operationBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(827, 376);
            this.dataGridView1.TabIndex = 3;
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            this.departureDataGridViewTextBoxColumn.Width = 125;
            // 
            // BusTypeText
            // 
            this.BusTypeText.DataPropertyName = "BusTypeText";
            this.BusTypeText.HeaderText = "BusTypeText";
            this.BusTypeText.MinimumWidth = 6;
            this.BusTypeText.Name = "BusTypeText";
            this.BusTypeText.ReadOnly = true;
            this.BusTypeText.Width = 125;
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
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            this.arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.HeaderText = "ArrivalTime";
            this.arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            this.arrivalTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "DepartureTime";
            this.departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // operationBindingSource
            // 

            // 
            // AddBusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AddBusControl";
            this.Size = new System.Drawing.Size(836, 487);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource operationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BusTypeText;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn operationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
    }
}
