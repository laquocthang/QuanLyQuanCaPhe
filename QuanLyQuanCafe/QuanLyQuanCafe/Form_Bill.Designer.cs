namespace QuanLyQuanCafe
{
	partial class Form_Bill
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bill));
			this.btn_TimTheoNhanVien = new System.Windows.Forms.Button();
			this.btn_TimTheoMaHD = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_TimTheoMaSK = new System.Windows.Forms.Button();
			this.btn_Xuat = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.tbx_MaSK = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbx_MaNV = new System.Windows.Forms.TextBox();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grid_Bill = new System.Windows.Forms.DataGridView();
			this.MãHóaĐơn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgàyHóaĐơn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MãNhânViên = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MãBàn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MãTầng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TổngTiền = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MãSựKiện = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ĐưaTrước = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CònLại = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbx_MaHD = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_Bill)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_TimTheoNhanVien
			// 
			this.btn_TimTheoNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoNhanVien.Location = new System.Drawing.Point(198, 28);
			this.btn_TimTheoNhanVien.Name = "btn_TimTheoNhanVien";
			this.btn_TimTheoNhanVien.Size = new System.Drawing.Size(86, 68);
			this.btn_TimTheoNhanVien.TabIndex = 9;
			this.btn_TimTheoNhanVien.Text = "Tìm theo Mã nhân viên";
			this.btn_TimTheoNhanVien.UseVisualStyleBackColor = true;
			this.btn_TimTheoNhanVien.Click += new System.EventHandler(this.btn_TimTheoNhanVien_Click);
			// 
			// btn_TimTheoMaHD
			// 
			this.btn_TimTheoMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoMaHD.Location = new System.Drawing.Point(6, 29);
			this.btn_TimTheoMaHD.Name = "btn_TimTheoMaHD";
			this.btn_TimTheoMaHD.Size = new System.Drawing.Size(87, 67);
			this.btn_TimTheoMaHD.TabIndex = 6;
			this.btn_TimTheoMaHD.Text = "Tìm theo Mã hóa đơn";
			this.btn_TimTheoMaHD.UseVisualStyleBackColor = true;
			this.btn_TimTheoMaHD.Click += new System.EventHandler(this.btn_TimTheoMaHD_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_TimTheoMaSK);
			this.groupBox1.Controls.Add(this.btn_TimTheoNhanVien);
			this.groupBox1.Controls.Add(this.btn_TimTheoMaHD);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 191);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(290, 107);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm nâng cao";
			// 
			// btn_TimTheoMaSK
			// 
			this.btn_TimTheoMaSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoMaSK.Location = new System.Drawing.Point(99, 29);
			this.btn_TimTheoMaSK.Name = "btn_TimTheoMaSK";
			this.btn_TimTheoMaSK.Size = new System.Drawing.Size(93, 67);
			this.btn_TimTheoMaSK.TabIndex = 8;
			this.btn_TimTheoMaSK.Text = "Tìm theo Mã sự kiện";
			this.btn_TimTheoMaSK.UseVisualStyleBackColor = true;
			this.btn_TimTheoMaSK.Click += new System.EventHandler(this.btn_TimTheoMaSK_Click);
			// 
			// btn_Xuat
			// 
			this.btn_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Xuat.Location = new System.Drawing.Point(83, 3);
			this.btn_Xuat.Name = "btn_Xuat";
			this.btn_Xuat.Size = new System.Drawing.Size(114, 35);
			this.btn_Xuat.TabIndex = 5;
			this.btn_Xuat.Text = "Xuất toàn bộ";
			this.btn_Xuat.UseVisualStyleBackColor = true;
			this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
			// 
			// panel7
			// 
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel7.Controls.Add(this.btn_Xuat);
			this.panel7.Location = new System.Drawing.Point(3, 144);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(287, 41);
			this.panel7.TabIndex = 5;
			// 
			// tbx_MaSK
			// 
			this.tbx_MaSK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaSK.Location = new System.Drawing.Point(130, 8);
			this.tbx_MaSK.MaxLength = 10;
			this.tbx_MaSK.Name = "tbx_MaSK";
			this.tbx_MaSK.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaSK.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(39, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Mã sự kiện";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.Controls.Add(this.tbx_MaSK);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Location = new System.Drawing.Point(3, 97);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(287, 41);
			this.panel3.TabIndex = 4;
			// 
			// tbx_MaNV
			// 
			this.tbx_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaNV.Location = new System.Drawing.Point(130, 8);
			this.tbx_MaNV.MaxLength = 50;
			this.tbx_MaNV.Name = "tbx_MaNV";
			this.tbx_MaNV.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaNV.TabIndex = 3;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 33);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grid_Bill);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(833, 520);
			this.splitContainer1.SplitterDistance = 527;
			this.splitContainer1.TabIndex = 3;
			// 
			// grid_Bill
			// 
			this.grid_Bill.AllowUserToResizeRows = false;
			this.grid_Bill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid_Bill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Bill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.MãHóaĐơn,
			this.NgàyHóaĐơn,
			this.MãNhânViên,
			this.MãBàn,
			this.MãTầng,
			this.TổngTiền,
			this.MãSựKiện,
			this.ĐưaTrước,
			this.CònLại});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_Bill.DefaultCellStyle = dataGridViewCellStyle1;
			this.grid_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_Bill.GridColor = System.Drawing.SystemColors.ScrollBar;
			this.grid_Bill.Location = new System.Drawing.Point(0, 0);
			this.grid_Bill.Name = "grid_Bill";
			this.grid_Bill.RowHeadersVisible = false;
			this.grid_Bill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_Bill.Size = new System.Drawing.Size(527, 520);
			this.grid_Bill.TabIndex = 0;
			// 
			// MãHóaĐơn
			// 
			this.MãHóaĐơn.DataPropertyName = "MãHóaĐơn";
			this.MãHóaĐơn.HeaderText = "Mã hóa đơn";
			this.MãHóaĐơn.Name = "MãHóaĐơn";
			// 
			// NgàyHóaĐơn
			// 
			this.NgàyHóaĐơn.DataPropertyName = "NgàyHóaĐơn";
			this.NgàyHóaĐơn.HeaderText = "Ngày hóa đơn";
			this.NgàyHóaĐơn.Name = "NgàyHóaĐơn";
			// 
			// MãNhânViên
			// 
			this.MãNhânViên.DataPropertyName = "MãNhânViên";
			this.MãNhânViên.HeaderText = "Mã nhân viên";
			this.MãNhânViên.Name = "MãNhânViên";
			// 
			// MãBàn
			// 
			this.MãBàn.DataPropertyName = "MãBàn";
			this.MãBàn.HeaderText = "Mã bàn";
			this.MãBàn.Name = "MãBàn";
			// 
			// MãTầng
			// 
			this.MãTầng.DataPropertyName = "MãTầng";
			this.MãTầng.HeaderText = "Mã tầng";
			this.MãTầng.Name = "MãTầng";
			// 
			// TổngTiền
			// 
			this.TổngTiền.DataPropertyName = "TổngTiền";
			this.TổngTiền.HeaderText = "Tổng tiền";
			this.TổngTiền.Name = "TổngTiền";
			// 
			// MãSựKiện
			// 
			this.MãSựKiện.DataPropertyName = "MãSựKiện";
			this.MãSựKiện.HeaderText = "Mã sự kiện";
			this.MãSựKiện.Name = "MãSựKiện";
			// 
			// ĐưaTrước
			// 
			this.ĐưaTrước.DataPropertyName = "ĐưaTrước";
			this.ĐưaTrước.HeaderText = "Đưa trước";
			this.ĐưaTrước.Name = "ĐưaTrước";
			// 
			// CònLại
			// 
			this.CònLại.DataPropertyName = "CònLại";
			this.CònLại.HeaderText = "Còn lại";
			this.CònLại.Name = "CònLại";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(302, 520);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.Controls.Add(this.tbx_MaHD);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(290, 41);
			this.panel2.TabIndex = 1;
			// 
			// tbx_MaHD
			// 
			this.tbx_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaHD.Location = new System.Drawing.Point(130, 8);
			this.tbx_MaHD.MaxLength = 5;
			this.tbx_MaHD.Name = "tbx_MaHD";
			this.tbx_MaHD.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaHD.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã hóa đơn";
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.Controls.Add(this.tbx_MaNV);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Location = new System.Drawing.Point(3, 50);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(287, 41);
			this.panel4.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Mã nhân viên";
			// 
			// lbl_Title
			// 
			this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(0, 0);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(833, 33);
			this.lbl_Title.TabIndex = 2;
			this.lbl_Title.Text = "DANH SÁCH HÓA ĐƠN";
			this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form_Bill
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 553);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.lbl_Title);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_Bill";
			this.Text = "DANH SÁCH HÓA ĐƠN";
			this.Load += new System.EventHandler(this.Form_Bill_Load);
			this.groupBox1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_Bill)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_TimTheoNhanVien;
		private System.Windows.Forms.Button btn_TimTheoMaHD;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Xuat;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.TextBox tbx_MaSK;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbx_MaNV;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView grid_Bill;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbx_MaHD;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_Title;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãHóaĐơn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgàyHóaĐơn;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãNhânViên;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãBàn;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãTầng;
		private System.Windows.Forms.DataGridViewTextBoxColumn TổngTiền;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãSựKiện;
		private System.Windows.Forms.DataGridViewTextBoxColumn ĐưaTrước;
		private System.Windows.Forms.DataGridViewTextBoxColumn CònLại;
		private System.Windows.Forms.Button btn_TimTheoMaSK;
	}
}