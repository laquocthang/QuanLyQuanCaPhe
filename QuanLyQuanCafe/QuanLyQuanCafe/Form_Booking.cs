using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	public partial class Form_Booking : Form
	{
		BalloonTooltip tooltip = new BalloonTooltip();
		User account = new User();
		CafeRestaurantEntities database = new CafeRestaurantEntities();
		Label selectedTable;

		public Form_Booking(User account)
		{
			InitializeComponent();
			this.Account = account;
		}

		/// <summary>
		/// Lấy loại tài khoản của người dùng hiện tại
		/// </summary>
		public User Account
		{
			get { return account; }
			set { account = value; }
		}

		#region Events

		private void Form_Booking_Load(object sender, EventArgs e)
		{
			if (User.Type)  //Nếu là nhân viên
			{
				côngCụQuảnTrịToolStripMenuItem.Enabled = false;
				côngCụQuảnTrịToolStripMenuItem.Visible = false;
			}
			else            //Nếu là người quản trị
			{
				côngCụQuảnTrịToolStripMenuItem.Enabled = true;
				côngCụQuảnTrịToolStripMenuItem.Visible = true;
			}
			AddOnClickToTable();
			Load_KhuyenMai();
			Load_ThucUong();
			AddTooltip();
		}

		private void lbl_refresh_Click(object sender, EventArgs e)
		{
			Load_KhuyenMai();
			Load_ThucUong();
		}


		private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Bạn có muốn thoát hoàn toàn khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
				Environment.Exit(1);
		}

		private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			DialogResult dialog = MessageBox.Show("Bạn có muốn đăng xuất khỏi ứng dụng?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
				this.Close();
		}

		private void quảnLýThứcUốngToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!User.Type) //Chỉ có người quản trị mới xem được form này
			{
				Form_DrinkManager form = new Form_DrinkManager();
				form.ShowDialog();
			}
		}

		private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!User.Type) //Chỉ có người quản trị mới xem được form này
			{
				Form_StaffManager form = new Form_StaffManager();
				form.ShowDialog();
			}
		}

		private void quảnLýSựKiệnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!User.Type) //Chỉ có người quản trị mới xem được form này
			{
				Form_EventManager form = new Form_EventManager();
				form.ShowDialog();
			}
		}

		private void thayĐổiThôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_ChangeInfo form = new Form_ChangeInfo(Account);
			form.ShowDialog();
		}

		private void Form_Booking_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)   //Nếu thoát bằng cách nhấn nút "x"
				thoátToolStripMenuItem1.PerformClick();
		}

		private void lbl_ChuyenThanhHoaDon_Click(object sender, EventArgs e)
		{
			if (grid_HoaDon.Rows.Count == 0)
			{
				MessageBox.Show("Chẳng có gì hết trơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (CheckBillIsSaved()) //Nếu hóa đơn đã được lưu
			{
				if (grid_DonHang.Rows.Count > 0)    //Thì xóa các dòng của bảng
					grid_HoaDon.Rows.Clear();
				string maHD = GetBillID();
				if (maHD != null)   //Cho vào bảng
				{
					string ngay = DateTime.Today.ToString("dd/MM/yyyy");
					string maNV = account.MaNhanVien;
					string[] maBan = lbl_BanChon.Text.Split('_');
					int tongTien = GetTotalPrice();
					int thanhTien = tongTien * (100 - GetDiscountPercent()) / 100;
					tbx_TongTien.Text = tongTien.ToString();
					tbx_ThanhTien.Text = thanhTien.ToString();
					string maSK;
					if (GetDiscountPercent() != 0)
						maSK = cbx_KhuyenMai.Text;
					else maSK = "NONAME";
					grid_HoaDon.Rows.Add(maHD, ngay, maNV, maBan[0], maBan[1], thanhTien, maSK);
				}
			}
			else    //Nếu hóa đơn chưa được lưu thì hỏi xác nhận trước khi tạo cái mới
			{
				DialogResult ask = MessageBox.Show("Bạn có muốn lưu hóa đơn trước đó vào CSDL rồi mới thêm hóa đơn mới không?\r\n" +
					"Nhấn Yes để lưu hóa đơn, Nhấn No để bỏ qua hóa đơn cũ để thay bằng hóa đơn mới", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (ask == DialogResult.Yes)    //Đồng ý lưu hóa đơn cũ
					lbl_InHD_Click(null, null);
				else if (ask == DialogResult.No)    //Xóa nếu không đồng ý
					grid_HoaDon.Rows.Clear();
				lbl_ChuyenThanhHoaDon_Click(sender, e); //Tiếp tục thêm hóa đơn mới
			}
		}

		private void lbl_InHD_Click(object sender, EventArgs e)
		{
			if (grid_HoaDon.Rows.Count == 0)
			{
				MessageBox.Show("Chưa có hóa đơn", "Thông báo");
				return;
			}
			else if (tbx_DuaTruoc.Text == "")
			{
				MessageBox.Show("Bạn chưa nhập số tiền mà khách đưa", "Thông báo");
				return;
			}
			DialogResult dialog = MessageBox.Show("Bạn có muốn xuất hóa đơn và đồng thời lưu vào hệ thống không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			if (dialog == DialogResult.OK)
			{
				if (AddBillToDb())
					AddOrderToDb();
			}
		}

		private void lbl_ChuyenBan_Click(object sender, EventArgs e)
		{
			Form_Moving form = new Form_Moving(table_Tang0, table_Tang1); //Truyền cho form chuyển bàn các thông tin cần thiết
			form.ShowDialog();
		}

		private void lbl_XoaBan_Click(object sender, EventArgs e)
		{
			selectedTable.ImageKey = "empty";
		}

		private void lbl_XoaTatCa_Click(object sender, EventArgs e)
		{
			//Ghép 2 danh sách controls cho một lệnh foreach
			foreach (Label item in table_Tang0.Controls.Cast<Label>().Concat(table_Tang1.Controls.Cast<Label>()))
			{
				item.ImageKey = "empty";
			}
		}

		private void lbl_XemHD_Click(object sender, EventArgs e)
		{
			Form_Bill form = new Form_Bill();
			form.ShowDialog();
		}

		private void btn_XoaDH_Click(object sender, EventArgs e)
		{
			DataGridViewRow selectedRow = (DataGridViewRow)grid_DonHang.SelectedRows[0];
			try
			{
				grid_DonHang.Rows.Remove(selectedRow);
			}
			catch (Exception)
			{
				//Do not thing
			}
		}

		private void btn_ThemDH_Click(object sender, EventArgs e)
		{
			if (lbl_BanChon.Text == "")
			{
				MessageBox.Show("Bạn chưa chọn bàn", "Thông báo");
				return;
			}
			else if (nud_SoLuong.Value == 0)
			{
				MessageBox.Show("Bạn chưa chọn số lượng thức uống", "Thông báo");
				return;
			}
			string[] temp = cbx_ThucUong.Text.Split('-');
			ThucUong thucUong = GetSelectedDrink(temp[0].Trim(), temp[1].Trim());
			if (thucUong == null)
			{
				MessageBox.Show("Không tìm thấy thức uống trong CSDL", "Thông báo");
				return;
			}
			string maDH = GetOrderID();
			string maHD = GetBillID();
			if (maDH != null && maHD != null)   //Thêm các đơn hàng vào bảng
			{
				string maTU = thucUong.MaThucUong;
				string maLoai = thucUong.MaLoai;
				int soLuong = (int)nud_SoLuong.Value;
				//--------Having the bug-----------
				if (grid_DonHang.Rows.Count == 0)
					grid_DonHang.Rows.Add(maDH, maTU, maLoai, soLuong, maHD);
				else
				{
					string maDH_TT = GetNextID(grid_DonHang.Rows[grid_DonHang.Rows.Count - 1].Cells[0].Value.ToString());
					grid_DonHang.Rows.Add(maDH_TT, maTU, maLoai, soLuong, maHD);
				}
				//-----------------------------------
			}
		}

		private void tbx_DuaTruoc_TextChanged(object sender, EventArgs e)
		{
			decimal thanhTien = 0;
			decimal duaTruoc = 0;
			if (Decimal.TryParse(tbx_ThanhTien.Text, out thanhTien) && Decimal.TryParse(tbx_DuaTruoc.Text, out duaTruoc))
				tbx_ConLai.Text = ((int)(duaTruoc - thanhTien)).ToString(); //Tự động tính tiền thối lại
		}

		private void thứcUốngBánChạyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!User.Type)
			{
				Form_BestSelling form = new Form_BestSelling();
				form.ShowDialog();
			}
		}

		private void thuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (!User.Type)
			{
				Form_InCome form = new Form_InCome();
				form.ShowDialog();
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// Áp dụng các sự kiện vào label chọn bàn
		/// </summary>
		void AddOnClickToTable()
		{
			foreach (Label label in table_Tang0.Controls.Cast<Control>().Concat(table_Tang1.Controls.Cast<Control>()))
			{
				label.Click += ChonBan;
			}
		}

		private void ChonBan(object sender, EventArgs e)
		{
			//Đưa mã bàn + mã tầng ra màn hình
			string text = (sender as Label).Name;
			lbl_BanChon.Text = text;
			tooltip.SetToopTip(lbl_BanChon, text);
			selectedTable = sender as Label;
			//Hiển thị thông tin của bàn
			ShowBillByID(tooltip.GetTooltip(selectedTable));
			ShowOrderByID(tooltip.GetTooltip(selectedTable));
		}

		/// <summary>
		/// Load các khuyến mãi hiện hành vào cbx_KhuyenMai
		/// </summary>
		void Load_KhuyenMai()
		{
			var list = (from data in database.SuKien
						where data.MaSuKien.Equals("NONAME") || //Mã sự kiện mặc định
						DateTime.Compare((DateTime)data.ThoiGian_KT, DateTime.Today) > 0    //MSK còn khả dụng
						select data.MaSuKien).ToList();
			cbx_KhuyenMai.DataSource = list;
			cbx_KhuyenMai.Text = "NONAME";
		}

		/// <summary>
		/// Load các thức uống hiện hành vào cbx_ThucUong
		/// </summary>
		void Load_ThucUong()
		{
			var list = (from data in database.ThucUong
						where data.KhaDung == true  //Thức uống khả dụng (còn hàng)
						select data.TenThucUong + " - " + data.MaLoai).ToList();
			cbx_ThucUong.DataSource = list;
		}

		/// <summary>
		/// Tìm kiếm và trả về một thức uống có trong CSDL
		/// </summary>
		/// <param name="tenTU">Tên thức uống</param>
		/// <param name="maLoai">Mã thức uống</param>
		/// <returns>Thức uống tương ứng</returns>
		ThucUong GetSelectedDrink(string tenTU, string maLoai)
		{
			ThucUong ketQua = null; //Kết quả mặc định nếu không tìm thấy
			ketQua = database.ThucUong.Where(d => d.TenThucUong.Equals(tenTU) && d.MaLoai.Equals(maLoai)).Single();
			return ketQua;
		}

		/// <summary>
		/// Tìm kiếm và trả về một thức uống có trong CSDL
		/// </summary>
		/// <param name="maTU">Mã thức uống</param>
		/// <param name="maLoai">Mã loại</param>
		/// <returns>Thức uống tương ứng</returns>
		ThucUong GetDrink(string maTU, string maLoai)
		{
			ThucUong ketQua = null;
			ketQua = database.ThucUong.Where(d => d.MaThucUong.Equals(maTU) && d.MaLoai.Equals(maLoai)).Single();
			return ketQua;
		}

		/// <summary>
		/// Lấy phần trăm giảm giá
		/// </summary>
		/// <returns>0 nếu mã giảm giá hết hạn, hết lượt khuyến mãi hoặc không áp dụng mã nào, ngược lại là số % được giảm</returns>
		int GetDiscountPercent()
		{
			string maGiamGia = cbx_KhuyenMai.SelectedText == "" ? cbx_KhuyenMai.Text : cbx_KhuyenMai.SelectedText;
			byte? ketQua = 0;   //Mặc định cho mã NONAME (không có sự kiện)
			ketQua = database.SuKien.Where(s
				=> s.MaSuKien.Equals("NONAME") || (s.MaSuKien.Equals(maGiamGia) && s.SoLuong > 0 && DateTime.Compare((DateTime)s.ThoiGian_KT, DateTime.Today) >= 0)).SingleOrDefault().TyLeGiam;
			return (int)ketQua;
		}

		/// <summary>
		/// Tính tổng giá sau khuyến mãi của các đơn hàng hiện tại
		/// </summary>
		/// <returns>Tổng tiền phải thanh toán</returns>
		int GetTotalPrice()
		{
			int sum = 0;
			for (int i = 0; i < grid_DonHang.Rows.Count; i++)
			{
				DataGridViewRow row = grid_DonHang.Rows[i];
				ThucUong thucUong = GetDrink(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
				if (thucUong == null)
				{
					MessageBox.Show("Không tìm thấy thức uống trong CSDL", "Thông báo");
					return 0;
				}
				sum += (int)thucUong.DonGia * int.Parse(row.Cells[3].Value.ToString()); //Đơn giá * số lượng
			}
			return sum;
		}

		/// <summary>
		/// Lấy mã đơn hàng khả dụng
		/// </summary>
		/// <returns>Mã đơn hàng DHddmmyyyxxxx</returns>
		string GetOrderID()
		{
			try
			{
				string result = database.Database.SqlQuery<string>("select dbo.fn_SinhMaDH()").FirstOrDefault();
				return result;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Lấy mã hóa đơn khả dụng
		/// </summary>
		/// <returns>Mã hóa đơn HDddmmyyyxxxx</returns>
		string GetBillID()
		{
			try
			{
				string result = database.Database.SqlQuery<string>("select dbo.fn_SinhMaHD()").FirstOrDefault();
				return result;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Tạo một id tiếp theo dựa vào ID ban đầu (áp dụng cho cả hóa đơn và đơn hàng)
		/// </summary>
		/// <param name="currentID">ID ban đầu (HDddmmyyxxxx hoặc DHddmmyyxxxx)</param>
		/// <returns>ID kế tiếp</returns>
		string GetNextID(string currentID)
		{
			try
			{
				string query = "select dbo.fn_TaoID_TiepTheo('" + currentID + "')";
				string result = database.Database.SqlQuery<string>(query).FirstOrDefault();
				return result;
			}
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				return null;
			}
		}

		/// <summary>
		/// Thêm tooltip cho các controls
		/// </summary>
		void AddTooltip()
		{
			tooltip.SetToopTip(lbl_ApDung, "Thêm các đơn hàng vào hóa đơn");
			tooltip.SetToopTip(lbl_InHD, "In hóa đơn");
			tooltip.SetToopTip(lbl_ChuyenBan, "Chuyển thông tin hóa đơn từ bàn này sang bàn khác");
			tooltip.SetToopTip(lbl_XoaBan, "Làm trống một bàn");
			tooltip.SetToopTip(lbl_XoaTatCa, "Làm trống tất cả các bàn");
			tooltip.SetToopTip(lbl_XemHD, "Xem danh sách hóa đơn");
			tooltip.SetToopTip(btn_ThemDH, "Thêm lựa chọn hiện tại vào danh sách đơn hàng");
			tooltip.SetToopTip(btn_XoaDH, "Xóa một lựa chọn ra khỏi danh sách đơn hàng");
		}

		/// <summary>
		/// Kiểm tra thông tin một hóa đơn nằm trên giao diện chính có lưu vào hệ thống chưa
		/// </summary>
		/// <returns>True nếu hóa đơn đó đã được lưu rồi hoặc khi trống, False nếu tồn tại mà chưa lưu</returns>
		bool CheckBillIsSaved()
		{
			if (grid_HoaDon.Rows.Count > 0)
			{
				DataGridViewRow row = grid_HoaDon.Rows[0];
				string maHD = row.Cells[0].Value.ToString();
				var result = (from data in database.HoaDon  //Tìm kiếm hóa đơn có trong CSDL không?
							  where data.MaHD.Equals(maHD)
							  select data).ToList();
				if (result.Count == 0)
					return false;
			}
			return true;
		}

		/// <summary>
		/// Thêm hóa đơn vào CSDL
		/// </summary>
		/// <returns>True nếu thành công, False nếu gặp vấn đề</returns>
		bool AddBillToDb()
		{
			DataGridViewRow row = grid_HoaDon.Rows[0];
			string maHoaDon = row.Cells[0].Value.ToString();
			SqlParameter maHD = new SqlParameter("@MaHD", maHoaDon);
			SqlParameter ngayHD = new SqlParameter("@NgayHD", row.Cells[1].Value.ToString());
			SqlParameter maNV = new SqlParameter("@MaNV", row.Cells[2].Value.ToString());
			SqlParameter maBan = new SqlParameter("@MaBan", row.Cells[3].Value.ToString());
			SqlParameter maTang = new SqlParameter("@MaTang", row.Cells[4].Value.ToString());
			SqlParameter thanhTien = new SqlParameter("@TongTien", tbx_ThanhTien.Text);
			SqlParameter maSK = new SqlParameter("@MaSuKien", row.Cells[6].Value.ToString());
			SqlParameter duaTruoc = new SqlParameter("@DuaTruoc", tbx_DuaTruoc.Text);
			SqlParameter conLai = new SqlParameter("@ConLai", tbx_ConLai.Text);
			if (int.Parse(tbx_ConLai.Text) < 0)
			{
				MessageBox.Show("Không thể tiếp tục hóa đơn vì khách hàng nợ", "Thông báo");
				return false;
			}
			var result = database.Database.ExecuteSqlCommand("exec usp_ThemHoaDon @MaHD, @NgayHD, @MaNV, @MaBan, @MaTang, @TongTien, @MaSuKien, @DuaTruoc, @ConLai",
				maHD, ngayHD, maNV, maBan, maTang, thanhTien, maSK, duaTruoc, conLai);
			PrintBill(maHoaDon);
			selectedTable.ImageKey = "full";
			AddTooltipToTable(maHoaDon);
			return true;
		}

		/// <summary>
		/// Thêm hóa đơn vào CSDL
		/// </summary>
		/// <returns>True nếu thành công, False nếu gặp vấn đề</returns>
		void AddOrderToDb()
		{
			foreach (DataGridViewRow row in grid_DonHang.Rows)
			{
				DonHang donHang = new DonHang
				{
					MaDonHang = row.Cells[0].Value.ToString(),
					MaThucUong = row.Cells[1].Value.ToString(),
					MaLoai = row.Cells[2].Value.ToString(),
					SoLuong = byte.Parse(row.Cells[3].Value.ToString()),
					MaHD = row.Cells[4].Value.ToString()
				};
				database.DonHang.Add(donHang);
				database.SaveChanges();
			}
		}

		/// <summary>
		/// In hóa đơn
		/// </summary>
		/// <param name="hoaDon">Hóa đơn cần in</param>
		private void PrintBill(string maHD)
		{
			HoaDon hoaDon = database.HoaDon.Where(b => b.MaHD.Equals(maHD)).SingleOrDefault();
			string printable = "MÃ HĐ: \t{0}\r\nNGÀY: \t{1}\r\nN.VIÊN: \t{2}\r\n"
				+ "BÀN: \t{3}\r\nTỔNG: \t{4}\r\nMÃ SK: \t{5}\r\nCẢM ƠN QUÝ KHÁCH\r\nHẸN GẶP LẠI LẦN SAU!";
			MessageBox.Show(string.Format(printable, hoaDon.MaHD, hoaDon.NgayHD.ToString("dd/MM/yyyy"), hoaDon.MaNV, hoaDon.MaBan + "-" + hoaDon.MaTang,
				hoaDon.TongTien, hoaDon.MaSuKien), "Hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//Còn thiếu chi tiết đơn hàng...
		}

		/// <summary>
		/// Thêm tooltip chính là mã hóa đơn của vị khách đang ngồi tại bàn
		/// </summary>
		/// <param name="text"></param>
		void AddTooltipToTable(string text)
		{
			tooltip.SetToopTip(selectedTable, text);
		}

		/// <summary>
		/// Hiển thị thông tin hóa đơn dựa theo mã hóa đơn
		/// </summary>
		/// <param name="id">Mã hóa đơn</param>
		void ShowBillByID(string id)
		{
			var table = from data in database.HoaDon
						where data.MaHD.Equals(id)
						select new
						{
							MãHóaĐơn = data.MaHD,
							NgàyHóaĐơn = data.NgayHD,
							MãNhânViên = data.MaNV,
							MãBàn = data.MaBan,
							MãTầng = data.MaTang,
							TổngTiền = data.TongTien,
							MãSựKiện = data.MaSuKien
						};
			grid_HoaDon.DataSource = table.ToList();
		}

		/// <summary>
		/// Hiển thị thông tin đơn hàng dựa vào mã hóa đơn
		/// </summary>
		/// <param name="id">Mã hóa đơn</param>
		void ShowOrderByID(string id)
		{
			var table = from data in database.DonHang
						where data.MaHD.Equals(id)
						select new
						{
							MãĐHàng = data.MaDonHang,
							MãThứcUống = data.MaThucUong,
							MãLoại = data.MaLoai,
							SốLượng = data.SoLuong,
							MãHĐơn = data.MaHD
						};
			grid_DonHang.DataSource = table.ToList();
		}

		#endregion

	}
}
