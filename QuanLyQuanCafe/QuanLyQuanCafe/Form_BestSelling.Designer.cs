namespace QuanLyQuanCafe
{
	partial class Form_BestSelling
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BestSelling));
			this.label1 = new System.Windows.Forms.Label();
			this.grid_Drink = new System.Windows.Forms.DataGridView();
			this.cbx_ThoiGian = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.grid_Drink)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(558, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "DANH SÁCH THỨC UỐNG BÁN CHẠY NHẤT";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grid_Drink
			// 
			this.grid_Drink.AllowUserToResizeRows = false;
			this.grid_Drink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grid_Drink.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.grid_Drink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.grid_Drink.DefaultCellStyle = dataGridViewCellStyle1;
			this.grid_Drink.GridColor = System.Drawing.SystemColors.ScrollBar;
			this.grid_Drink.Location = new System.Drawing.Point(0, 76);
			this.grid_Drink.Name = "grid_Drink";
			this.grid_Drink.RowHeadersVisible = false;
			this.grid_Drink.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid_Drink.Size = new System.Drawing.Size(558, 353);
			this.grid_Drink.TabIndex = 1;
			// 
			// cbx_ThoiGian
			// 
			this.cbx_ThoiGian.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cbx_ThoiGian.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.cbx_ThoiGian.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
			this.cbx_ThoiGian.FormattingEnabled = true;
			this.cbx_ThoiGian.Items.AddRange(new object[] {
            "Từ trước tới nay",
            "Trong năm",
            "Trong quý",
            "Trong tháng",
            "Trong ngày"});
			this.cbx_ThoiGian.Location = new System.Drawing.Point(245, 39);
			this.cbx_ThoiGian.Name = "cbx_ThoiGian";
			this.cbx_ThoiGian.Size = new System.Drawing.Size(231, 28);
			this.cbx_ThoiGian.TabIndex = 2;
			this.cbx_ThoiGian.SelectedIndexChanged += new System.EventHandler(this.cbx_ThoiGian_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(81, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Chọn mốc thời gian:";
			// 
			// Form_BestSelling
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 429);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbx_ThoiGian);
			this.Controls.Add(this.grid_Drink);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form_BestSelling";
			this.Text = "THỨC UỐNG BÁN CHẠY";
			this.Load += new System.EventHandler(this.Form_BestSelling_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid_Drink)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView grid_Drink;
		private System.Windows.Forms.ComboBox cbx_ThoiGian;
		private System.Windows.Forms.Label label2;
	}
}