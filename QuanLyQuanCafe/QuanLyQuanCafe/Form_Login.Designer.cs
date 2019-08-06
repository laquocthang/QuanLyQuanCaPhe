namespace QuanLyQuanCafe
{
	partial class Form_Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbl_Forget = new System.Windows.Forms.Label();
			this.btn_Login = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.tbx_Username = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbx_Password = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 135);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(479, 135);
			this.panel1.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbl_Forget);
			this.panel4.Controls.Add(this.btn_Login);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.panel4.Location = new System.Drawing.Point(0, 90);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(479, 45);
			this.panel4.TabIndex = 3;
			this.panel4.TabStop = true;
			// 
			// lbl_Forget
			// 
			this.lbl_Forget.AutoSize = true;
			this.lbl_Forget.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lbl_Forget.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline);
			this.lbl_Forget.ForeColor = System.Drawing.Color.DodgerBlue;
			this.lbl_Forget.Location = new System.Drawing.Point(356, 18);
			this.lbl_Forget.Name = "lbl_Forget";
			this.lbl_Forget.Size = new System.Drawing.Size(111, 19);
			this.lbl_Forget.TabIndex = 4;
			this.lbl_Forget.Text = "Quên mật khẩu?";
			this.lbl_Forget.Click += new System.EventHandler(this.lbl_Forget_Click);
			// 
			// btn_Login
			// 
			this.btn_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 12.25F);
			this.btn_Login.Location = new System.Drawing.Point(183, 3);
			this.btn_Login.Name = "btn_Login";
			this.btn_Login.Size = new System.Drawing.Size(121, 34);
			this.btn_Login.TabIndex = 3;
			this.btn_Login.Text = "Đăng nhập";
			this.btn_Login.UseVisualStyleBackColor = true;
			this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.tbx_Username);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.panel3.Location = new System.Drawing.Point(0, 19);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(479, 35);
			this.panel3.TabIndex = 1;
			this.panel3.TabStop = true;
			// 
			// tbx_Username
			// 
			this.tbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbx_Username.Location = new System.Drawing.Point(203, 6);
			this.tbx_Username.MaxLength = 100;
			this.tbx_Username.Name = "tbx_Username";
			this.tbx_Username.Size = new System.Drawing.Size(198, 26);
			this.tbx_Username.TabIndex = 1;
			this.tbx_Username.Text = "admin";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(114, 21);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên đăng nhập:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbx_Password);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.panel2.Location = new System.Drawing.Point(0, 52);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(479, 35);
			this.panel2.TabIndex = 2;
			this.panel2.TabStop = true;
			// 
			// tbx_Password
			// 
			this.tbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tbx_Password.Location = new System.Drawing.Point(203, 5);
			this.tbx_Password.MaxLength = 100;
			this.tbx_Password.Name = "tbx_Password";
			this.tbx_Password.PasswordChar = '*';
			this.tbx_Password.Size = new System.Drawing.Size(198, 26);
			this.tbx_Password.TabIndex = 2;
			this.tbx_Password.Text = "admin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.label3.Location = new System.Drawing.Point(92, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 21);
			this.label3.TabIndex = 1;
			this.label3.Text = "Mật khẩu:";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.pictureBox1);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(479, 155);
			this.panel5.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(183, 30);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(479, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "CHÀO MỪNG BẠN ĐẾN VỚI ỨNG DỤNG QUẢN LÝ QUÁN CÀ PHÊ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(61, 4);
			// 
			// đăngXuấtToolStripMenuItem
			// 
			this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
			this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// thoátToolStripMenuItem
			// 
			this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
			this.thoátToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
			// 
			// Form_Login
			// 
			this.AcceptButton = this.btn_Login;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(479, 270);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form_Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ĐĂNG NHẬP";
			this.Load += new System.EventHandler(this.Login_Load);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbx_Password;
		private System.Windows.Forms.TextBox tbx_Username;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Login;
		private System.Windows.Forms.Label lbl_Forget;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
	}
}

