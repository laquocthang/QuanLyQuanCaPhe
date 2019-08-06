using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class Form_Login : Form
	{
		public Form_Login()
		{
			InitializeComponent();
		}

		#region Events

		private void Login_Load(object sender, EventArgs e)
		{
			AddTooltip();
		}

		private void lbl_Forget_Click(object sender, EventArgs e)
		{
			string content = "1) Nếu bạn là admin, vui lòng liên hệ với tác giả phần mềm để khôi phục:\r\n\t - Họ và tên: " +
				QuanLyQuanCafe.Properties.Resources.authorName + " - " + QuanLyQuanCafe.Properties.Resources.authorInfo +
				"\r\n\t - Số điện thoại: " + QuanLyQuanCafe.Properties.Resources.authorPhone +
				"\r\n\t - Email: " + QuanLyQuanCafe.Properties.Resources.authorEmail +
				"\r\n\t - Địa chỉ: " + QuanLyQuanCafe.Properties.Resources.authorAddress;
			content += "\r\n\n2) Nếu bạn là nhân viên, vui lòng liên hệ với chủ cửa hàng để reset thông tin:\r\n\t - Họ và tên: " +
				QuanLyQuanCafe.Properties.Resources.adminName + " - " + QuanLyQuanCafe.Properties.Resources.adminInfo +
				"\r\n\t - Số điện thoại: " + QuanLyQuanCafe.Properties.Resources.adminPhone +
				"\r\n\t - Email: " + QuanLyQuanCafe.Properties.Resources.adminEmail +
				"\r\n\t - Địa chỉ: " + QuanLyQuanCafe.Properties.Resources.adminAddress;
			MessageBox.Show(content, "QUÊN MẬT KHẨU");
		}

		private void btn_Login_Click(object sender, EventArgs e)
		{
			string username = tbx_Username.Text;
			string password = tbx_Password.Text;
			if (username.Equals("") || password.Equals(""))
			{
				MessageBox.Show("Các trường không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (username.Equals(""))
					tbx_Username.Focus();
				else tbx_Password.Focus();
			}
			else
			{
				User user = new User();
				if (user.Login(username, password))
				{
					playAudio();
					Form_Booking form = new Form_Booking(user);
					this.Hide();
					form.ShowDialog();
					resetFields();
					this.Show();
				}
				else
				{
					DialogResult dialog = MessageBox.Show("Đăng nhập không thành công! Bạn có muốn tiếp tục đăng nhập?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
					if (dialog == DialogResult.Cancel)
					{
						Application.Exit();
					}
				}
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Phát âm thanh khi đăng nhập thành công
		/// </summary>
		void playAudio()
		{
			Stream audio = Properties.Resources.success;
			SoundPlayer player = new SoundPlayer(audio);
			player.Play();
		}

		/// <summary>
		/// Xóa bỏ các thông tin đăng nhập được nhập vào
		/// </summary>
		void resetFields()
		{
			tbx_Username.Text = "";
			tbx_Password.Text = "";
			tbx_Username.Focus();
		}

		/// <summary>
		/// Thêm tooltip cho các button
		/// </summary>
		void AddTooltip()
		{
			BalloonTooltip tip = new BalloonTooltip();
			tip.SetToopTip(lbl_Forget, "Nhấn vào đây nếu bạn quên mật khẩu");
			tip.SetToopTip(tbx_Username, "Nhập vào tên đăng nhập (username) của bạn");
			tip.SetToopTip(tbx_Password, "Nhập vào mật khẩu (password) của bạn");
			tip.SetToopTip(btn_Login, "Xác nhận thông tin và đăng nhập vào hệ thống");
		}

		#endregion
	}
}
