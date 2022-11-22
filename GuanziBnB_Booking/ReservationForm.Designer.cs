namespace GuanziBnB_Booking
{
	partial class ReservationForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
			this.label2 = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.dtgReservation = new System.Windows.Forms.DataGridView();
			this.Create_at = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CancelStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label2.Location = new System.Drawing.Point(44, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "預定清單";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.BackColor = System.Drawing.Color.Transparent;
			this.lblInfo.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblInfo.ForeColor = System.Drawing.Color.White;
			this.lblInfo.Location = new System.Drawing.Point(43, 50);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(53, 19);
			this.lblInfo.TabIndex = 3;
			this.lblInfo.Text = "lblInfo";
			// 
			// dtgReservation
			// 
			this.dtgReservation.AllowUserToAddRows = false;
			this.dtgReservation.AllowUserToDeleteRows = false;
			this.dtgReservation.AllowUserToResizeColumns = false;
			this.dtgReservation.AllowUserToResizeRows = false;
			this.dtgReservation.AutoGenerateColumns = false;
			this.dtgReservation.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dtgReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtgReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Create_at,
            this.CancelStatus});
			this.dtgReservation.DataSource = this.bindingSource1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.AliceBlue;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtgReservation.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtgReservation.GridColor = System.Drawing.SystemColors.Control;
			this.dtgReservation.Location = new System.Drawing.Point(35, 131);
			this.dtgReservation.Name = "dtgReservation";
			this.dtgReservation.ReadOnly = true;
			this.dtgReservation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.GhostWhite;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtgReservation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dtgReservation.RowHeadersWidth = 35;
			this.dtgReservation.RowTemplate.Height = 24;
			this.dtgReservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtgReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtgReservation.Size = new System.Drawing.Size(473, 261);
			this.dtgReservation.TabIndex = 1;
			this.dtgReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgReservation_CellClick);
			this.dtgReservation.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dtgReservation_RowPostPaint);
			// 
			// Create_at
			// 
			this.Create_at.DataPropertyName = "Create_at";
			this.Create_at.FillWeight = 304.5685F;
			this.Create_at.HeaderText = "訂單成立時間";
			this.Create_at.Name = "Create_at";
			this.Create_at.ReadOnly = true;
			this.Create_at.Width = 150;
			// 
			// CancelStatus
			// 
			this.CancelStatus.DataPropertyName = "CancelStatus";
			this.CancelStatus.FillWeight = 48.85786F;
			this.CancelStatus.HeaderText = "取消  訂單";
			this.CancelStatus.Name = "CancelStatus";
			this.CancelStatus.ReadOnly = true;
			this.CancelStatus.Width = 55;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Start_date";
			this.dataGridViewTextBoxColumn3.FillWeight = 48.85786F;
			this.dataGridViewTextBoxColumn3.HeaderText = "入住日期";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 115;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "End_date";
			this.dataGridViewTextBoxColumn4.FillWeight = 48.85786F;
			this.dataGridViewTextBoxColumn4.HeaderText = "退房日期";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 115;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = typeof(GuanziBnB_Booking.Models.ViewModels.ReservationIndexVM);
			// 
			// ReservationForm
			// 
			this.BackgroundImage = global::GuanziBnB_Booking.Properties.Resources.Search;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(543, 431);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.dtgReservation);
			this.Controls.Add(this.label2);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReservationForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "查詢預定";
			this.Load += new System.EventHandler(this.ReservationForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtgReservation)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dtgVReservation;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn enddateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn roomqtyDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn addBedDataGridViewCheckBoxColumn;
		private System.Windows.Forms.BindingSource reservationIndexVMBindingSource;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.DataGridView dtgReservation;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Create_at;
		private System.Windows.Forms.DataGridViewCheckBoxColumn CancelStatus;
	}
}