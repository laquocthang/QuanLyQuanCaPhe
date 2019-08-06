using System;
using System.Linq;

namespace QuanLyQuanCafe
{
	/// <summary>
	/// Xử lý Ngày tháng năm định dạng kiểu Việt Nam
	/// </summary>
	class VNDateTime
	{
		/// <summary>
		/// Khởi tạo ngày tháng dựa vào các số nguyên
		/// </summary>
		/// <param name="day">Ngày</param>
		/// <param name="month">Tháng</param>
		/// <param name="year">Năm</param>
		/// <param name="datetime">Kết quả</param>
		/// <returns>True nếu khởi tạo thành công, False nếu không thành công</returns>
		public static bool Initial(int day, int month, int year, out DateTime datetime)
		{
			datetime = new DateTime();
			try
			{
				datetime = new DateTime(year, month, day);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Khởi tạo ngày dựa trên 3 chuỗi
		/// </summary>
		/// <param name="day">Ngày</param>
		/// <param name="month">Tháng</param>
		/// <param name="year">Năm</param>
		/// <param name="datetime">Kết quả</param>
		/// <returns>True nếu khởi tạo thành công, False nếu không thành công</returns>
		public static bool Initial(string day, string month, string year, out DateTime datetime)
		{
			datetime = new DateTime();
			try
			{
				int _day = Convert.ToInt32(day);
				int _month = Convert.ToInt32(month);
				int _year = Convert.ToInt32(year);
				datetime = new DateTime(_year, _month, _day);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Khởi tạo ngày dựa trên 2 chuỗi
		/// </summary>
		/// <param name="month">Tháng</param>
		/// <param name="year">Năm</param>
		/// <param name="datetime">Kết quả</param>
		/// <returns>True nếu khởi tạo thành công, False nếu không thành công</returns>
		public static bool Initial(string month, string year, out DateTime datetime)
		{
			datetime = new DateTime();
			try
			{
				int _month = Convert.ToInt32(month);
				int _year = Convert.ToInt32(year);
				datetime = new DateTime(_year, _month, 1);
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		/// <summary>
		/// Khởi tạo ngày dựa vào một chuỗi
		/// </summary>
		/// <param name="date">Ngày tháng năm dạng dd/MM/yyyy</param>
		/// <param name="datetime">Kết quả</param>
		/// <returns>True nếu khởi tạo thành công, False nếu không thành công</returns>
		public static bool Initial(string date, out DateTime datetime)
		{
			datetime = new DateTime();
			if (date.Count(c => c.Equals('/')) == 2)
			{
				try
				{
					string[] temp = date.Split('/');
					int _day = Convert.ToInt32(temp[0]);
					int _month = Convert.ToInt32(temp[1]);
					int _year = Convert.ToInt32(temp[2]);
					datetime = new DateTime(_year, _month, _day);
					return true;
				}
				catch (Exception)
				{
					return false;
				}
			}
			return false;
		}
	}
}
