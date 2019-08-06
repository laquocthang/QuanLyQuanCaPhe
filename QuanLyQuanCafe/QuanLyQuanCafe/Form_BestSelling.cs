using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class Form_BestSelling : Form
	{
		int nam = 0, thang = 0, ngay = 0, quy = 0;

		#region Events

		public Form_BestSelling()
		{
			InitializeComponent();
		}

		public Form_BestSelling(int nam, int quy, int thang, int ngay)
		{
			InitializeComponent();
		}

		private void Form_BestSelling_Load(object sender, EventArgs e)
		{
			if (nam == 0)
				GetDateTime();
		}

		private void cbx_ThoiGian_SelectedIndexChanged(object sender, EventArgs e)
		{
			CountAllDrinkOrder(cbx_ThoiGian.SelectedIndex);
		}

		#endregion

		#region Methods

		private void GetDateTime()
		{
			DateTime today = DateTime.Today;
			nam = today.Year;
			thang = today.Month;
			quy = (thang + 2) / 3;
			ngay = today.Day;
		}

		/// <summary>
		/// Thống kê đơn hàng một loại nước uống  theo loại thời gian (ngày, tháng, quý, năm, tất cả)
		/// </summary>
		/// <param name="ten"></param>
		/// <param name="maLoai"></param>
		/// <param name="maTU"></param>
		/// <param name="indexTime"></param>
		/// <returns></returns>
		DrinkOrder CountOrderByTime(string ten, string maLoai, string maTU, int indexTime)
		{
			using (var database = new CafeRestaurantEntities())
			{
				DrinkOrder drink = new DrinkOrder(maLoai, maTU, ten);
				string tag;
				if (database.DonHang.Count() == 0)
					indexTime = -1;
				switch (indexTime)
				{
					case 0:     //Tat ca
						drink.SoLuong = database.DonHang.Where(o => o.MaLoai.Equals(maLoai) && o.MaThucUong.Equals(maTU)).Sum(o => o.SoLuong);
						break;
					case 1:     //Nam
						tag = DateTime.Today.ToString("yy");
						drink.SoLuong =
							database.DonHang.Where(o => o.MaDonHang.Substring(6, 2).Equals(tag))
							.Sum(o => o.SoLuong);
						break;
					case 2:     //Quy
						int quarter = (DateTime.Today.Month + 2) / 3;
						string year = DateTime.Today.ToString("yy");
						drink.SoLuong =
							database.DonHang.AsEnumerable().Where(o =>
							{
								string thang = o.MaDonHang.Substring(4, 2);
								string nam = o.MaDonHang.Substring(6, 2);
								if ((int.Parse(thang) + 2) / 3 == quarter && nam.Equals(year))
									return true;
								else return false;
							}).Sum(o => o.SoLuong);
						break;
					case 3:     //Thang
						tag = DateTime.Today.ToString("MMyy");
						drink.SoLuong = database.DonHang.Where(o => o.MaDonHang.Substring(4, 4).Equals(tag)).Sum(o => o.SoLuong);
						break;
					case 4:     //Ngay
						tag = DateTime.Today.ToString("ddMMyy");
						drink.SoLuong = database.DonHang.Where(o => o.MaDonHang.Substring(2, 6).Equals(tag)).Sum(o => o.SoLuong);
						break;
					default:    //Không có gì
						drink.SoLuong = 0;
						break;
				}
				return drink;
			}
		}

		/// <summary>
		/// Thống kê đơn hàng tất cả các loại nước uống 
		/// </summary>
		/// <param name="indexTime"></param>
		void CountAllDrinkOrder(int indexTime)
		{
			using (var database = new CafeRestaurantEntities())
			{
				var list_drink = database.ThucUong.ToList();
				List<DrinkOrder> list_result = new List<DrinkOrder>();
				foreach (var item in list_drink)
				{
					if (item.KhaDung == true)
					{
						list_result.Add(CountOrderByTime(item.TenThucUong, item.MaLoai, item.MaThucUong, indexTime));
					}
				}
				list_result.OrderBy(d => d.SoLuong);
				grid_Drink.DataSource = list_result;
			}
		}
		#endregion
	}
}
