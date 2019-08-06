namespace QuanLyQuanCafe
{
	partial class Form_EventManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EventManager));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grid_Event = new System.Windows.Forms.DataGridView();
			this.MãSựKiện = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TênSựKiện = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TỷLệGiảm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SốLượng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgàyBắtĐầu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgàyKếtThúc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbx_MaSuKien = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbx_TenSuKien = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbx_TyLe = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbx_SoLuong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tbx_NgayBD = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.tbx_NgayKT = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn_Xuat = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_KhaDung = new System.Windows.Forms.Button();
			this.btn_TimTheoTL = new System.Windows.Forms.Button();
			this.btn_TimTheoMa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_Event)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel7.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 33);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grid_Event);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(834, 543);
			this.splitContainer1.SplitterDistance = 530;
			this.splitContainer1.TabIndex = 3;
			// 
			// grid_Event
			// 
			this.grid_Event.AllowUserToResizeRows = false;
			this.grid_Event.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid_Event.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Event.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MãSựKiện,
            this.TênSựKiện,
            this.TỷLệGiảm,
            this.SốLượng,
            this.NgàyBắtĐầu,
            this.NgàyKếtThúc});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_Event.DefaultCellStyle = dataGridViewCellStyle1;
			this.grid_Event.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_Event.GridColor = System.Drawing.SystemColors.ScrollBar;
			this.grid_Event.Location = new System.Drawing.Point(0, 0);
			this.grid_Event.Name = "grid_Event";
			this.grid_Event.RowHeadersVisible = false;
			this.grid_Event.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_Event.Size = new System.Drawing.Size(530, 543);
			this.grid_Event.TabIndex = 0;
			// 
			// MãSựKiện
			// 
			this.MãSựKiện.DataPropertyName = "MãSựKiện";
			this.MãSựKiện.HeaderText = "Mã sự kiện";
			this.MãSựKiện.Name = "MãSựKiện";
			// 
			// TênSựKiện
			// 
			this.TênSựKiện.DataPropertyName = "TênSựKiện";
			this.TênSựKiện.HeaderText = "Tên sự kiện";
			this.TênSựKiện.Name = "TênSựKiện";
			// 
			// TỷLệGiảm
			// 
			this.TỷLệGiảm.DataPropertyName = "TỷLệGiảm";
			this.TỷLệGiảm.HeaderText = "Tỷ lệ giảm";
			this.TỷLệGiảm.Name = "TỷLệGiảm";
			// 
			// SốLượng
			// 
			this.SốLượng.DataPropertyName = "SốLượng";
			this.SốLượng.HeaderText = "Số lượng";
			this.SốLượng.Name = "SốLượng";
			// 
			// NgàyBắtĐầu
			// 
			this.NgàyBắtĐầu.DataPropertyName = "NgàyBắtĐầu";
			this.NgàyBắtĐầu.HeaderText = "Ngày bắt đầu ";
			this.NgàyBắtĐầu.Name = "NgàyBắtĐầu";
			// 
			// NgàyKếtThúc
			// 
			this.NgàyKếtThúc.DataPropertyName = "NgàyKếtThúc";
			this.NgàyKếtThúc.HeaderText = "Ngày kết thúc";
			this.NgàyKếtThúc.Name = "NgàyKếtThúc";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel8);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 543);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbx_MaSuKien);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(290, 35);
			this.panel2.TabIndex = 1;
			// 
			// tbx_MaSuKien
			// 
			this.tbx_MaSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaSuKien.Location = new System.Drawing.Point(115, 6);
			this.tbx_MaSuKien.MaxLength = 10;
			this.tbx_MaSuKien.Name = "tbx_MaSuKien";
			this.tbx_MaSuKien.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaSuKien.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã sự kiện";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbx_TenSuKien);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 44);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 80);
			this.panel1.TabIndex = 2;
			// 
			// tbx_TenSuKien
			// 
			this.tbx_TenSuKien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_TenSuKien.Location = new System.Drawing.Point(115, 3);
			this.tbx_TenSuKien.MaxLength = 256;
			this.tbx_TenSuKien.Multiline = true;
			this.tbx_TenSuKien.Name = "tbx_TenSuKien";
			this.tbx_TenSuKien.Size = new System.Drawing.Size(144, 71);
			this.tbx_TenSuKien.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(23, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên sự kiện";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.tbx_TyLe);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 130);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(287, 35);
			this.panel4.TabIndex = 3;
			// 
			// tbx_TyLe
			// 
			this.tbx_TyLe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_TyLe.Location = new System.Drawing.Point(115, 6);
			this.tbx_TyLe.MaxLength = 5;
			this.tbx_TyLe.Name = "tbx_TyLe";
			this.tbx_TyLe.Size = new System.Drawing.Size(76, 26);
			this.tbx_TyLe.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(28, 8);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tỷ lệ giảm";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbx_SoLuong);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 171);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(287, 35);
			this.panel3.TabIndex = 4;
			// 
			// tbx_SoLuong
			// 
			this.tbx_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_SoLuong.Location = new System.Drawing.Point(115, 6);
			this.tbx_SoLuong.MaxLength = 5;
			this.tbx_SoLuong.Name = "tbx_SoLuong";
			this.tbx_SoLuong.Size = new System.Drawing.Size(144, 26);
			this.tbx_SoLuong.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Số lượng";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.tbx_NgayBD);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(3, 212);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(287, 35);
			this.panel5.TabIndex = 5;
			// 
			// tbx_NgayBD
			// 
			this.tbx_NgayBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_NgayBD.Location = new System.Drawing.Point(115, 6);
			this.tbx_NgayBD.MaxLength = 15;
			this.tbx_NgayBD.Name = "tbx_NgayBD";
			this.tbx_NgayBD.Size = new System.Drawing.Size(144, 26);
			this.tbx_NgayBD.TabIndex = 5;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(6, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ngày bắt đầu";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.tbx_NgayKT);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(3, 253);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(287, 35);
			this.panel6.TabIndex = 6;
			// 
			// tbx_NgayKT
			// 
			this.tbx_NgayKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_NgayKT.Location = new System.Drawing.Point(115, 8);
			this.tbx_NgayKT.MaxLength = 15;
			this.tbx_NgayKT.Name = "tbx_NgayKT";
			this.tbx_NgayKT.Size = new System.Drawing.Size(144, 26);
			this.tbx_NgayKT.TabIndex = 6;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(2, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 21);
			this.label7.TabIndex = 0;
			this.label7.Text = "Ngày kết thúc";
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.btn_Xuat);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(3, 294);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(287, 41);
			this.panel8.TabIndex = 7;
			// 
			// btn_Xuat
			// 
			this.btn_Xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Xuat.Location = new System.Drawing.Point(83, 3);
			this.btn_Xuat.Name = "btn_Xuat";
			this.btn_Xuat.Size = new System.Drawing.Size(114, 35);
			this.btn_Xuat.TabIndex = 7;
			this.btn_Xuat.Text = "Xuất toàn bộ";
			this.btn_Xuat.UseVisualStyleBackColor = true;
			this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.btn_Xoa);
			this.panel7.Controls.Add(this.btn_Sua);
			this.panel7.Controls.Add(this.btn_Them);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(3, 341);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(287, 41);
			this.panel7.TabIndex = 8;
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Xoa.Location = new System.Drawing.Point(97, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(90, 35);
			this.btn_Xoa.TabIndex = 9;
			this.btn_Xoa.Text = "Xóa";
			this.btn_Xoa.UseVisualStyleBackColor = true;
			this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
			// 
			// btn_Sua
			// 
			this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Sua.Location = new System.Drawing.Point(193, 3);
			this.btn_Sua.Name = "btn_Sua";
			this.btn_Sua.Size = new System.Drawing.Size(90, 35);
			this.btn_Sua.TabIndex = 10;
			this.btn_Sua.Text = "Sửa";
			this.btn_Sua.UseVisualStyleBackColor = true;
			this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
			// 
			// btn_Them
			// 
			this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Them.Location = new System.Drawing.Point(1, 3);
			this.btn_Them.Name = "btn_Them";
			this.btn_Them.Size = new System.Drawing.Size(90, 35);
			this.btn_Them.TabIndex = 8;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_KhaDung);
			this.groupBox1.Controls.Add(this.btn_TimTheoTL);
			this.groupBox1.Controls.Add(this.btn_TimTheoMa);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 388);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 91);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm nâng cao";
			// 
			// btn_KhaDung
			// 
			this.btn_KhaDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_KhaDung.Location = new System.Drawing.Point(193, 28);
			this.btn_KhaDung.Name = "btn_KhaDung";
			this.btn_KhaDung.Size = new System.Drawing.Size(85, 55);
			this.btn_KhaDung.TabIndex = 13;
			this.btn_KhaDung.Text = "Khả dụng";
			this.btn_KhaDung.UseVisualStyleBackColor = true;
			this.btn_KhaDung.Click += new System.EventHandler(this.btn_KhaDung_Click);
			// 
			// btn_TimTheoTL
			// 
			this.btn_TimTheoTL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoTL.Location = new System.Drawing.Point(97, 28);
			this.btn_TimTheoTL.Name = "btn_TimTheoTL";
			this.btn_TimTheoTL.Size = new System.Drawing.Size(90, 55);
			this.btn_TimTheoTL.TabIndex = 12;
			this.btn_TimTheoTL.Text = "Tìm theo Tỷ lệ";
			this.btn_TimTheoTL.UseVisualStyleBackColor = true;
			this.btn_TimTheoTL.Click += new System.EventHandler(this.btn_TimTheoTL_Click);
			// 
			// btn_TimTheoMa
			// 
			this.btn_TimTheoMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoMa.Location = new System.Drawing.Point(6, 28);
			this.btn_TimTheoMa.Name = "btn_TimTheoMa";
			this.btn_TimTheoMa.Size = new System.Drawing.Size(85, 55);
			this.btn_TimTheoMa.TabIndex = 11;
			this.btn_TimTheoMa.Text = "Tìm theo Mã sự kiện";
			this.btn_TimTheoMa.UseVisualStyleBackColor = true;
			this.btn_TimTheoMa.Click += new System.EventHandler(this.btn_TimTheoMa_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(834, 33);
			this.label1.TabIndex = 2;
			this.label1.Text = "QUẢN LÝ DANH SÁCH SỰ KIỆN KHUYẾN MÃI";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form_EventManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 576);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_EventManager";
			this.Text = "QUẢN LÝ SỰ KIỆN KHUYẾN MÃI";
			this.Load += new System.EventHandler(this.Form_EventManager_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_Event)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView grid_Event;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbx_MaSuKien;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbx_TenSuKien;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tbx_TyLe;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbx_SoLuong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox tbx_NgayBD;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox tbx_NgayKT;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_TimTheoTL;
		private System.Windows.Forms.Button btn_TimTheoMa;
		private System.Windows.Forms.Button btn_KhaDung;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãSựKiện;
		private System.Windows.Forms.DataGridViewTextBoxColumn TênSựKiện;
		private System.Windows.Forms.DataGridViewTextBoxColumn TỷLệGiảm;
		private System.Windows.Forms.DataGridViewTextBoxColumn SốLượng;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgàyBắtĐầu;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgàyKếtThúc;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button btn_Xuat;
	}
}