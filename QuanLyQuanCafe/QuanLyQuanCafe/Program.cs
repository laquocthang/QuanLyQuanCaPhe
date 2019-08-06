using System;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			bool result;
			//Kiểm tra ứng dụng có đang được chạy trước đó hay không
			var mutex = new Mutex(true, "UniqueAppId", out result);
			if(!result)
			{
				MessageBox.Show("Ứng dụng đang được chạy! Bạn vui lòng đóng ứng dụng trước đó rồi thử lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			Application.Run(new Form_Login());
		}
	}
}
