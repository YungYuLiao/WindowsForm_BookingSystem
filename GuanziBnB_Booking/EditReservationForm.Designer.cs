namespace GuanziBnB_Booking
{
	partial class EditReservationForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReservationForm));
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblReservationId = new System.Windows.Forms.Label();
			this.lblNonPaid = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.lblRemit_account = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.lblPaid = new System.Windows.Forms.Label();
			this.lblPaidTime = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.lblName_remit = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.lblCancel = new System.Windows.Forms.Label();
			this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.enddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addBedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.reservationIndexVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.reservationIndexVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "訂單編號 :";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.AliceBlue;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnUpdate.Location = new System.Drawing.Point(407, 390);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(88, 31);
			this.btnUpdate.TabIndex = 0;
			this.btnUpdate.Text = "取消訂單";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(24, 25);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "待付金額 :";
			// 
			// lblReservationId
			// 
			this.lblReservationId.AutoSize = true;
			this.lblReservationId.Location = new System.Drawing.Point(100, 31);
			this.lblReservationId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblReservationId.Name = "lblReservationId";
			this.lblReservationId.Size = new System.Drawing.Size(44, 17);
			this.lblReservationId.TabIndex = 8;
			this.lblReservationId.Text = "label6";
			// 
			// lblNonPaid
			// 
			this.lblNonPaid.AutoSize = true;
			this.lblNonPaid.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblNonPaid.Location = new System.Drawing.Point(103, 22);
			this.lblNonPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblNonPaid.Name = "lblNonPaid";
			this.lblNonPaid.Size = new System.Drawing.Size(52, 17);
			this.lblNonPaid.TabIndex = 12;
			this.lblNonPaid.Text = "label10";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Controls.Add(this.lblReservationId);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox1.Location = new System.Drawing.Point(42, 172);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox1.Size = new System.Drawing.Size(453, 210);
			this.groupBox1.TabIndex = 13;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "訂單詳情";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeColumns = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomtypeDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.enddateDataGridViewTextBoxColumn,
            this.addBedDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.reservationIndexVMBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView1.Location = new System.Drawing.Point(9, 54);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView1.Size = new System.Drawing.Size(437, 147);
			this.dataGridView1.TabIndex = 17;
			this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label6.Location = new System.Drawing.Point(272, 57);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(105, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "匯款帳號後五碼 :";
			// 
			// lblRemit_account
			// 
			this.lblRemit_account.AutoSize = true;
			this.lblRemit_account.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblRemit_account.Location = new System.Drawing.Point(385, 59);
			this.lblRemit_account.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblRemit_account.Name = "lblRemit_account";
			this.lblRemit_account.Size = new System.Drawing.Size(44, 17);
			this.lblRemit_account.TabIndex = 14;
			this.lblRemit_account.Text = "label7";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.lblPaid);
			this.groupBox2.Controls.Add(this.lblPaidTime);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.lblName_remit);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.lblRemit_account);
			this.groupBox2.Controls.Add(this.lblNonPaid);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.groupBox2.ForeColor = System.Drawing.Color.Black;
			this.groupBox2.Location = new System.Drawing.Point(44, 45);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
			this.groupBox2.Size = new System.Drawing.Size(451, 119);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "付款資訊";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.ForeColor = System.Drawing.Color.White;
			this.label10.Location = new System.Drawing.Point(272, 25);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 17);
			this.label10.TabIndex = 19;
			this.label10.Text = "已匯金額 :";
			// 
			// lblPaid
			// 
			this.lblPaid.AutoSize = true;
			this.lblPaid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblPaid.Location = new System.Drawing.Point(352, 25);
			this.lblPaid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPaid.Name = "lblPaid";
			this.lblPaid.Size = new System.Drawing.Size(52, 17);
			this.lblPaid.TabIndex = 20;
			this.lblPaid.Text = "label10";
			// 
			// lblPaidTime
			// 
			this.lblPaidTime.AutoSize = true;
			this.lblPaidTime.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblPaidTime.Location = new System.Drawing.Point(98, 93);
			this.lblPaidTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPaidTime.Name = "lblPaidTime";
			this.lblPaidTime.Size = new System.Drawing.Size(44, 17);
			this.lblPaidTime.TabIndex = 18;
			this.lblPaidTime.Text = "label7";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(24, 94);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 17;
			this.label9.Text = "匯款時間 :";
			// 
			// lblName_remit
			// 
			this.lblName_remit.AutoSize = true;
			this.lblName_remit.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblName_remit.Location = new System.Drawing.Point(111, 57);
			this.lblName_remit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblName_remit.Name = "lblName_remit";
			this.lblName_remit.Size = new System.Drawing.Size(44, 17);
			this.lblName_remit.TabIndex = 16;
			this.lblName_remit.Text = "label9";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(24, 57);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(79, 17);
			this.label8.TabIndex = 15;
			this.label8.Text = "匯款人姓名 :";
			// 
			// lblCancel
			// 
			this.lblCancel.AutoSize = true;
			this.lblCancel.BackColor = System.Drawing.Color.Brown;
			this.lblCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblCancel.ForeColor = System.Drawing.Color.White;
			this.lblCancel.Location = new System.Drawing.Point(414, 20);
			this.lblCancel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(51, 19);
			this.lblCancel.TabIndex = 16;
			this.lblCancel.Text = "label7";
			// 
			// roomtypeDataGridViewTextBoxColumn
			// 
			this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "Room_type";
			this.roomtypeDataGridViewTextBoxColumn.HeaderText = "房型";
			this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
			this.roomtypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// startdateDataGridViewTextBoxColumn
			// 
			this.startdateDataGridViewTextBoxColumn.DataPropertyName = "Start_date";
			this.startdateDataGridViewTextBoxColumn.HeaderText = "入住時間";
			this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
			this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
			this.startdateDataGridViewTextBoxColumn.Width = 120;
			// 
			// enddateDataGridViewTextBoxColumn
			// 
			this.enddateDataGridViewTextBoxColumn.DataPropertyName = "End_date";
			this.enddateDataGridViewTextBoxColumn.HeaderText = "退住時間";
			this.enddateDataGridViewTextBoxColumn.Name = "enddateDataGridViewTextBoxColumn";
			this.enddateDataGridViewTextBoxColumn.ReadOnly = true;
			this.enddateDataGridViewTextBoxColumn.Width = 120;
			// 
			// addBedDataGridViewTextBoxColumn
			// 
			this.addBedDataGridViewTextBoxColumn.DataPropertyName = "AddBed";
			this.addBedDataGridViewTextBoxColumn.HeaderText = "加床與否";
			this.addBedDataGridViewTextBoxColumn.Name = "addBedDataGridViewTextBoxColumn";
			this.addBedDataGridViewTextBoxColumn.ReadOnly = true;
			this.addBedDataGridViewTextBoxColumn.Width = 95;
			// 
			// reservationIndexVMBindingSource
			// 
			this.reservationIndexVMBindingSource.DataSource = typeof(GuanziBnB_Booking.Models.ViewModels.ReservationIndexVM);
			// 
			// EditReservationForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::GuanziBnB_Booking.Properties.Resources.Edit;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(543, 431);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.lblCancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "EditReservationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "編輯訂房訂單";
			this.Load += new System.EventHandler(this.EditReservationForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.reservationIndexVMBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblReservationId;
		private System.Windows.Forms.Label lblNonPaid;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblRemit_account;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lblName_remit;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblCancel;
		private System.Windows.Forms.Label lblPaidTime;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lblPaid;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.BindingSource reservationIndexVMBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addBedDataGridViewTextBoxColumn;
	}
}