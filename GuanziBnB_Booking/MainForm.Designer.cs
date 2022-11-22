namespace GuanziBnB_Booking
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnBook = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.lblGreet = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblRoomType = new System.Windows.Forms.Label();
			this.btnLeft = new System.Windows.Forms.Button();
			this.btnRight = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdateUser = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBook
			// 
			this.btnBook.BackColor = System.Drawing.Color.Transparent;
			this.btnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBook.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnBook.ForeColor = System.Drawing.Color.Transparent;
			this.btnBook.Location = new System.Drawing.Point(669, 9);
			this.btnBook.Name = "btnBook";
			this.btnBook.Size = new System.Drawing.Size(75, 36);
			this.btnBook.TabIndex = 0;
			this.btnBook.Text = "立即訂房";
			this.btnBook.UseVisualStyleBackColor = false;
			this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.BackColor = System.Drawing.Color.Transparent;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnSearch.ForeColor = System.Drawing.Color.Transparent;
			this.btnSearch.Location = new System.Drawing.Point(763, 9);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 36);
			this.btnSearch.TabIndex = 1;
			this.btnSearch.Text = "查詢預定";
			this.btnSearch.UseVisualStyleBackColor = false;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// lblGreet
			// 
			this.lblGreet.AutoSize = true;
			this.lblGreet.BackColor = System.Drawing.Color.Transparent;
			this.lblGreet.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblGreet.ForeColor = System.Drawing.Color.White;
			this.lblGreet.Location = new System.Drawing.Point(461, 21);
			this.lblGreet.Name = "lblGreet";
			this.lblGreet.Size = new System.Drawing.Size(56, 17);
			this.lblGreet.TabIndex = 2;
			this.lblGreet.Text = "lblGreet";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label2.Location = new System.Drawing.Point(414, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "房型預覽";
			// 
			// lblRoomType
			// 
			this.lblRoomType.AutoSize = true;
			this.lblRoomType.BackColor = System.Drawing.Color.Transparent;
			this.lblRoomType.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblRoomType.ForeColor = System.Drawing.Color.White;
			this.lblRoomType.Location = new System.Drawing.Point(38, 390);
			this.lblRoomType.Name = "lblRoomType";
			this.lblRoomType.Size = new System.Drawing.Size(73, 20);
			this.lblRoomType.TabIndex = 4;
			this.lblRoomType.Text = "房型介紹";
			// 
			// btnLeft
			// 
			this.btnLeft.BackColor = System.Drawing.Color.White;
			this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btnLeft.Image = global::GuanziBnB_Booking.Properties.Resources.Button_L;
			this.btnLeft.Location = new System.Drawing.Point(357, 440);
			this.btnLeft.Name = "btnLeft";
			this.btnLeft.Size = new System.Drawing.Size(35, 35);
			this.btnLeft.TabIndex = 4;
			this.btnLeft.UseVisualStyleBackColor = false;
			this.btnLeft.Click += new System.EventHandler(this.goBack);
			// 
			// btnRight
			// 
			this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRight.ForeColor = System.Drawing.Color.White;
			this.btnRight.Image = global::GuanziBnB_Booking.Properties.Resources.Button_R1;
			this.btnRight.Location = new System.Drawing.Point(882, 440);
			this.btnRight.Name = "btnRight";
			this.btnRight.Size = new System.Drawing.Size(35, 35);
			this.btnRight.TabIndex = 3;
			this.btnRight.UseVisualStyleBackColor = true;
			this.btnRight.Click += new System.EventHandler(this.goNext);
			// 
			// btnLogout
			// 
			this.btnLogout.BackColor = System.Drawing.Color.Transparent;
			this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogout.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnLogout.ForeColor = System.Drawing.Color.White;
			this.btnLogout.Location = new System.Drawing.Point(857, 9);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(75, 36);
			this.btnLogout.TabIndex = 2;
			this.btnLogout.Text = "登出";
			this.btnLogout.UseVisualStyleBackColor = false;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(412, 268);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(450, 360);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.label1.Location = new System.Drawing.Point(37, 254);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 27);
			this.label1.TabIndex = 10;
			this.label1.Text = "房型介紹";
			// 
			// btnUpdateUser
			// 
			this.btnUpdateUser.BackColor = System.Drawing.Color.Transparent;
			this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdateUser.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btnUpdateUser.ForeColor = System.Drawing.Color.Transparent;
			this.btnUpdateUser.Location = new System.Drawing.Point(553, 9);
			this.btnUpdateUser.Name = "btnUpdateUser";
			this.btnUpdateUser.Size = new System.Drawing.Size(97, 36);
			this.btnUpdateUser.TabIndex = 11;
			this.btnUpdateUser.Text = "會員資料更新";
			this.btnUpdateUser.UseVisualStyleBackColor = false;
			this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::GuanziBnB_Booking.Properties.Resources.MainForm1;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(952, 651);
			this.Controls.Add(this.btnUpdateUser);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnRight);
			this.Controls.Add(this.btnLeft);
			this.Controls.Add(this.lblRoomType);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblGreet);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnBook);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "嘉義梅山．觀紫民宿";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBook;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Label lblGreet;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblRoomType;
		private System.Windows.Forms.Button btnLeft;
		private System.Windows.Forms.Button btnRight;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdateUser;
	}
}