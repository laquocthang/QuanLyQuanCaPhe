namespace QuanLyQuanCafe
{
	partial class Form_DrinkManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DrinkManager));
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.grid_Drink = new System.Windows.Forms.DataGridView();
			this.MãThứcUống = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MãLoại = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TênThứcUống = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ĐơnGiá = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhảDụng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbx_MaThucUong = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbx_MaLoai = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tbx_TenThucUong = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbx_DonGia = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.chk_KhaDung = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.btn_Xuat = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn_Xoa = new System.Windows.Forms.Button();
			this.btn_Sua = new System.Windows.Forms.Button();
			this.btn_Them = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_KhaDung = new System.Windows.Forms.Button();
			this.btn_TimTheoGia = new System.Windows.Forms.Button();
			this.btn_TimTheoTen = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid_Drink)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(815, 33);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ DANH MỤC THỨC UỐNG";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 33);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.grid_Drink);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(815, 481);
			this.splitContainer1.SplitterDistance = 518;
			this.splitContainer1.TabIndex = 1;
			// 
			// grid_Drink
			// 
			this.grid_Drink.AllowUserToResizeRows = false;
			this.grid_Drink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid_Drink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid_Drink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MãThứcUống,
            this.MãLoại,
            this.TênThứcUống,
            this.ĐơnGiá,
            this.KhảDụng});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_Drink.DefaultCellStyle = dataGridViewCellStyle1;
			this.grid_Drink.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid_Drink.GridColor = System.Drawing.SystemColors.ScrollBar;
			this.grid_Drink.Location = new System.Drawing.Point(0, 0);
			this.grid_Drink.Name = "grid_Drink";
			this.grid_Drink.RowHeadersVisible = false;
			this.grid_Drink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_Drink.Size = new System.Drawing.Size(518, 481);
			this.grid_Drink.TabIndex = 0;
			// 
			// MãThứcUống
			// 
			this.MãThứcUống.DataPropertyName = "MãThứcUống";
			this.MãThứcUống.HeaderText = "Mã thức uống";
			this.MãThứcUống.Name = "MãThứcUống";
			// 
			// MãLoại
			// 
			this.MãLoại.DataPropertyName = "MãLoại";
			this.MãLoại.HeaderText = "Mã loại";
			this.MãLoại.Name = "MãLoại";
			// 
			// TênThứcUống
			// 
			this.TênThứcUống.DataPropertyName = "TênThứcUống";
			this.TênThứcUống.HeaderText = "Tên thức uống";
			this.TênThứcUống.Name = "TênThứcUống";
			// 
			// ĐơnGiá
			// 
			this.ĐơnGiá.DataPropertyName = "ĐơnGiá";
			this.ĐơnGiá.HeaderText = "Đơn giá";
			this.ĐơnGiá.Name = "ĐơnGiá";
			// 
			// KhảDụng
			// 
			this.KhảDụng.DataPropertyName = "KhảDụng";
			this.KhảDụng.HeaderText = "Khả dụng";
			this.KhảDụng.Name = "KhảDụng";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.panel2);
			this.flowLayoutPanel1.Controls.Add(this.panel1);
			this.flowLayoutPanel1.Controls.Add(this.panel4);
			this.flowLayoutPanel1.Controls.Add(this.panel3);
			this.flowLayoutPanel1.Controls.Add(this.panel6);
			this.flowLayoutPanel1.Controls.Add(this.panel7);
			this.flowLayoutPanel1.Controls.Add(this.panel5);
			this.flowLayoutPanel1.Controls.Add(this.groupBox1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(293, 481);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbx_MaThucUong);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(3, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(290, 41);
			this.panel2.TabIndex = 1;
			// 
			// tbx_MaThucUong
			// 
			this.tbx_MaThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaThucUong.Location = new System.Drawing.Point(109, 8);
			this.tbx_MaThucUong.MaxLength = 5;
			this.tbx_MaThucUong.Name = "tbx_MaThucUong";
			this.tbx_MaThucUong.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaThucUong.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(3, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(106, 21);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mã thức uống";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbx_MaLoai);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 50);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(290, 41);
			this.panel1.TabIndex = 2;
			// 
			// tbx_MaLoai
			// 
			this.tbx_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_MaLoai.Location = new System.Drawing.Point(109, 8);
			this.tbx_MaLoai.MaxLength = 4;
			this.tbx_MaLoai.Name = "tbx_MaLoai";
			this.tbx_MaLoai.Size = new System.Drawing.Size(144, 26);
			this.tbx_MaLoai.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(42, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mã loại";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.tbx_TenThucUong);
			this.panel4.Controls.Add(this.label5);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(3, 97);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(287, 41);
			this.panel4.TabIndex = 3;
			// 
			// tbx_TenThucUong
			// 
			this.tbx_TenThucUong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_TenThucUong.Location = new System.Drawing.Point(109, 8);
			this.tbx_TenThucUong.MaxLength = 50;
			this.tbx_TenThucUong.Name = "tbx_TenThucUong";
			this.tbx_TenThucUong.Size = new System.Drawing.Size(175, 26);
			this.tbx_TenThucUong.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tên thức uống";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbx_DonGia);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(3, 144);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(287, 41);
			this.panel3.TabIndex = 4;
			// 
			// tbx_DonGia
			// 
			this.tbx_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.tbx_DonGia.Location = new System.Drawing.Point(109, 8);
			this.tbx_DonGia.MaxLength = 10;
			this.tbx_DonGia.Name = "tbx_DonGia";
			this.tbx_DonGia.Size = new System.Drawing.Size(144, 26);
			this.tbx_DonGia.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(38, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 21);
			this.label4.TabIndex = 0;
			this.label4.Text = "Đơn giá";
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.chk_KhaDung);
			this.panel6.Controls.Add(this.label6);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(3, 191);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(287, 41);
			this.panel6.TabIndex = 5;
			// 
			// chk_KhaDung
			// 
			this.chk_KhaDung.AutoSize = true;
			this.chk_KhaDung.Location = new System.Drawing.Point(109, 16);
			this.chk_KhaDung.Name = "chk_KhaDung";
			this.chk_KhaDung.Size = new System.Drawing.Size(15, 14);
			this.chk_KhaDung.TabIndex = 4;
			this.chk_KhaDung.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(27, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 21);
			this.label6.TabIndex = 0;
			this.label6.Text = "Khả dụng";
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.btn_Xuat);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(3, 238);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(287, 41);
			this.panel7.TabIndex = 9;
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
			// panel5
			// 
			this.panel5.Controls.Add(this.btn_Xoa);
			this.panel5.Controls.Add(this.btn_Sua);
			this.panel5.Controls.Add(this.btn_Them);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(3, 285);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(287, 41);
			this.panel5.TabIndex = 5;
			// 
			// btn_Xoa
			// 
			this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btn_Xoa.Location = new System.Drawing.Point(97, 3);
			this.btn_Xoa.Name = "btn_Xoa";
			this.btn_Xoa.Size = new System.Drawing.Size(90, 35);
			this.btn_Xoa.TabIndex = 7;
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
			this.btn_Sua.TabIndex = 8;
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
			this.btn_Them.TabIndex = 6;
			this.btn_Them.Text = "Thêm";
			this.btn_Them.UseVisualStyleBackColor = true;
			this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_KhaDung);
			this.groupBox1.Controls.Add(this.btn_TimTheoGia);
			this.groupBox1.Controls.Add(this.btn_TimTheoTen);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 332);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 91);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Tìm kiếm nâng cao";
			// 
			// btn_KhaDung
			// 
			this.btn_KhaDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_KhaDung.Location = new System.Drawing.Point(203, 28);
			this.btn_KhaDung.Name = "btn_KhaDung";
			this.btn_KhaDung.Size = new System.Drawing.Size(75, 55);
			this.btn_KhaDung.TabIndex = 11;
			this.btn_KhaDung.Text = "Khả dụng";
			this.btn_KhaDung.UseVisualStyleBackColor = true;
			this.btn_KhaDung.Click += new System.EventHandler(this.btn_KhaDung_Click);
			// 
			// btn_TimTheoGia
			// 
			this.btn_TimTheoGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoGia.Location = new System.Drawing.Point(116, 28);
			this.btn_TimTheoGia.Name = "btn_TimTheoGia";
			this.btn_TimTheoGia.Size = new System.Drawing.Size(81, 55);
			this.btn_TimTheoGia.TabIndex = 10;
			this.btn_TimTheoGia.Text = "Tìm theo Đơn giá";
			this.btn_TimTheoGia.UseVisualStyleBackColor = true;
			this.btn_TimTheoGia.Click += new System.EventHandler(this.btn_TimTheoGia_Click);
			// 
			// btn_TimTheoTen
			// 
			this.btn_TimTheoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.btn_TimTheoTen.Location = new System.Drawing.Point(6, 28);
			this.btn_TimTheoTen.Name = "btn_TimTheoTen";
			this.btn_TimTheoTen.Size = new System.Drawing.Size(104, 55);
			this.btn_TimTheoTen.TabIndex = 9;
			this.btn_TimTheoTen.Text = "Tìm theo Tên thức uống";
			this.btn_TimTheoTen.UseVisualStyleBackColor = true;
			this.btn_TimTheoTen.Click += new System.EventHandler(this.btn_TimTheoTen_Click);
			// 
			// Form_DrinkManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(815, 514);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_DrinkManager";
			this.Text = "QUẢN LÝ THỨC UỐNG";
			this.Load += new System.EventHandler(this.From_DrinkManager_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid_Drink)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView grid_Drink;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbx_MaThucUong;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbx_MaLoai;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tbx_TenThucUong;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox tbx_DonGia;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btn_Them;
		private System.Windows.Forms.Button btn_Xoa;
		private System.Windows.Forms.Button btn_Sua;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_TimTheoGia;
		private System.Windows.Forms.Button btn_TimTheoTen;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.CheckBox chk_KhaDung;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btn_KhaDung;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãThứcUống;
		private System.Windows.Forms.DataGridViewTextBoxColumn MãLoại;
		private System.Windows.Forms.DataGridViewTextBoxColumn TênThứcUống;
		private System.Windows.Forms.DataGridViewTextBoxColumn ĐơnGiá;
		private System.Windows.Forms.DataGridViewTextBoxColumn KhảDụng;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Button btn_Xuat;
	}
}