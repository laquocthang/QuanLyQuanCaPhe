namespace QuanLyQuanCafe
{
	class DrinkOrder
	{
		private string tenThucUong;
		private string maThucUong;
		private string maLoai;
		private int soLuong;

		public DrinkOrder()
		{

		}

		public DrinkOrder(string maLoai, string maThucUong, string tenThucUong)
		{
			this.maLoai = maLoai;
			this.maThucUong = maThucUong;
			this.tenThucUong = tenThucUong;
			this.soLuong = 0;
		}

		public string TenThucUong
		{
			get { return tenThucUong; }
			set { tenThucUong = value; }
		}

		public string MaThucUong
		{
			get { return maThucUong; }
			set { maThucUong = value; }
		}

		public string MaLoai
		{
			get { return maLoai; }
			set { maLoai = value; }
		}

		public int SoLuong
		{
			get { return soLuong; }
			set { soLuong = value; }
		}
	}
}
