
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
            this.bttAddBus = new System.Windows.Forms.Button();
            this.bttManageReservation = new System.Windows.Forms.Button();
            this.bttSchedule = new System.Windows.Forms.Button();
            this.bttSalesCondition = new System.Windows.Forms.Button();
            this.bttTop3 = new System.Windows.Forms.Button();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bttAddBus
            // 
            this.bttAddBus.Location = new System.Drawing.Point(111, 46);
            this.bttAddBus.Name = "bttAddBus";
            this.bttAddBus.Size = new System.Drawing.Size(117, 23);
            this.bttAddBus.TabIndex = 0;
            this.bttAddBus.Text = "운행 추가";
            this.bttAddBus.UseVisualStyleBackColor = true;
            // 
            // bttManageReservation
            // 
            this.bttManageReservation.Location = new System.Drawing.Point(376, 46);
            this.bttManageReservation.Name = "bttManageReservation";
            this.bttManageReservation.Size = new System.Drawing.Size(131, 23);
            this.bttManageReservation.TabIndex = 2;
            this.bttManageReservation.Text = "예약 관리";
            this.bttManageReservation.UseVisualStyleBackColor = true;
            // 
            // bttSchedule
            // 
            this.bttSchedule.Location = new System.Drawing.Point(244, 46);
            this.bttSchedule.Name = "bttSchedule";
            this.bttSchedule.Size = new System.Drawing.Size(126, 23);
            this.bttSchedule.TabIndex = 3;
            this.bttSchedule.Text = "운행 스케줄";
            this.bttSchedule.UseVisualStyleBackColor = true;
            // 
            // bttSalesCondition
            // 
            this.bttSalesCondition.Location = new System.Drawing.Point(513, 46);
            this.bttSalesCondition.Name = "bttSalesCondition";
            this.bttSalesCondition.Size = new System.Drawing.Size(135, 23);
            this.bttSalesCondition.TabIndex = 4;
            this.bttSalesCondition.Text = "월별 매출 현황";
            this.bttSalesCondition.UseVisualStyleBackColor = true;
            // 
            // bttTop3
            // 
            this.bttTop3.Location = new System.Drawing.Point(654, 46);
            this.bttTop3.Name = "bttTop3";
            this.bttTop3.Size = new System.Drawing.Size(119, 23);
            this.bttTop3.TabIndex = 5;
            this.bttTop3.Text = "상위 노선 보기";
            this.bttTop3.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Location = new System.Drawing.Point(35, 148);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1120, 480);
            this.pnlContainer.TabIndex = 6;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.bttTop3);
            this.Controls.Add(this.bttSalesCondition);
            this.Controls.Add(this.bttSchedule);
            this.Controls.Add(this.bttManageReservation);
            this.Controls.Add(this.bttAddBus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttAddBus;
        private System.Windows.Forms.Button bttManageReservation;
        private System.Windows.Forms.Button bttSchedule;
        private System.Windows.Forms.Button bttSalesCondition;
        private System.Windows.Forms.Button bttTop3;
        private System.Windows.Forms.Panel pnlContainer;
    }
}