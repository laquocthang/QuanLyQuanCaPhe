using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class Form_InCome : Form
	{
		int nam = 0, quy = 0, thang = 0, ngay = 0;

		public Form_InCome()
		{
			InitializeComponent();
		}

		public Form_InCome(int nam, int quy, int thang, int ngay)
		{
			InitializeComponent();
			this.nam = nam;
			this.quy = quy;
			this.thang = thang;
			this.ngay = ngay;
		}

		private void Form_InCome_Load(object sender, EventArgs e)
		{
			if (nam == 0)
				GetDateTime();
			ShowIncome();
		}

		/// <summary>
		/// Gán thời gian hiện tại vào các biến
		/// </summary>
		void GetDateTime()
		{
			DateTime today = DateTime.Today;
			nam = today.Year;
			thang = today.Month;
			quy = (thang + 2) / 3;
			ngay = today.Day;
		}

		/// <summary>
		/// Xuất thu nhập qua các mốc thời gian
		/// </summary>
		void ShowIncome()
		{
			ShowIncome_Total();
			ShowIncome_Year();
			ShowIncome_Quarter();
			ShowIncome_Month();
			ShowIncome_Day();
		}

		private void ShowIncome_Day()
		{
			using (var database = new CafeRestaurantEntities())
			{
				if (database.HoaDon.Count() == 0)
					tbx_TongTrongNgay.Text = "0";
				else tbx_TongTrongNgay.Text = database.HoaDon.Where(b => b.NgayHD.Day == ngay && b.NgayHD.Month == thang && b.NgayHD.Year == nam)
					.Sum(b => b.TongTien).ToString();
			}
		}

		private void ShowIncome_Month()
		{
			using (var database = new CafeRestaurantEntities())
			{
				if (database.HoaDon.Count() == 0)
					tbx_TongTrongThang.Text = "0";
				else tbx_TongTrongThang.Text = database.HoaDon.Where(b => b.NgayHD.Month == thang && b.NgayHD.Year == nam)
					.Sum(b => b.TongTien).ToString();
			}
		}

		private void ShowIncome_Quarter()
		{
			using (var database = new CafeRestaurantEntities())
			{
				if (database.HoaDon.Count() == 0)
					tbx_TongTrongQuy.Text = "0";
				else tbx_TongTrongQuy.Text = database.HoaDon.Where(b => (b.NgayHD.Month + 2) / 3 == quy && b.NgayHD.Year == nam)
					.Sum(b => b.TongTien).ToString();
			}
		}

		private void ShowIncome_Year()
		{
			using (var database = new CafeRestaurantEntities())
			{
				if (database.HoaDon.Count() == 0)
					tbx_TongTrongNam.Text = "0";
				else tbx_TongTrongNam.Text = database.HoaDon.Where(b => b.NgayHD.Year == nam)
					.Sum(b => b.TongTien).ToString();
			}
		}

		void ShowIncome_Total()
		{
			using (var database = new CafeRestaurantEntities())
			{
				if (database.HoaDon.Count() == 0)
					tbx_TongThuNhap.Text = "0";
				else tbx_TongThuNhap.Text = database.HoaDon.Sum(b => b.TongTien).ToString();
			}
		}
	}
}
