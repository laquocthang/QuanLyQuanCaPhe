using System.Windows.Forms;

namespace QuanLyQuanCafe
{
	/// <summary>
	/// Mách nước cho các control
	/// </summary>
	public class BalloonTooltip
	{
		ToolTip tip = new ToolTip();

		#region Constructors

		/// <summary>
		/// Khởi tạo với các giá trị mặc định
		/// </summary>
		public BalloonTooltip()
		{
			tip.AutoPopDelay = 5000;
			tip.InitialDelay = 1000;
			tip.ReshowDelay = 500;
			tip.ShowAlways = true;
		}

		/// <summary>
		/// Khởi tạo với thời gian hiển thị mách nước tùy chỉnh
		/// </summary>
		/// <param name="AutoPop">Thời gian hiển thị - Đơn vị ms</param>
		public BalloonTooltip(int AutoPop = 5000)
		{
			tip.AutoPopDelay = AutoPop;
		}

		/// <summary>
		/// Khởi tạo với thời gian hiển thị và thời gian chờ tùy chỉnh
		/// </summary>
		/// <param name="AutoPop">Thời gian hiển thị - Đơn vị ms</param>
		/// <param name="Initial">Thời gian chờ để mách nước hiển thị - Đơn vị ms</param>
		public BalloonTooltip(int AutoPop, int Initial = 1000)
		{
			tip.AutoPopDelay = AutoPop;
			tip.InitialDelay = Initial;
		}

		/// <summary>
		/// Khởi tạo mách nước
		/// </summary>
		/// <param name="AutoPop">Thời gian hiển thị - Đơn vị ms</param>
		/// <param name="Initial">Thời gian chờ để hiển thị - Đơn vị ms</param>
		/// <param name="Reshow">Thời gian để mách nước này hiển thị trước khi một mách nước khác xuất hiện</param>
		public BalloonTooltip(int AutoPop, int Initial, int Reshow = 500)
		{
			tip.AutoPopDelay = AutoPop;
			tip.InitialDelay = Initial;
			tip.ReshowDelay = Reshow;
		}

		/// <summary>
		/// Khởi tạo mách nước
		/// </summary>
		/// <param name="AutoPop">Thời gian hiển thị - Đơn vị ms</param>
		/// <param name="Initial">Thời gian chờ để hiển thị - Đơn vị ms</param>
		/// <param name="Reshow">Thời gian để mách nước này hiển thị trước khi một mách nước khác xuất hiện</param>
		/// <param name="ShowAlways">Luôn hiển thị cho dù nó có được kích hoạt hay không</param>
		public BalloonTooltip(int AutoPop, int Initial, int Reshow, bool ShowAlways = true)
		{
			tip.AutoPopDelay = AutoPop;
			tip.InitialDelay = Initial;
			tip.ReshowDelay = Reshow;
			tip.ShowAlways = ShowAlways;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Cài mách nước vào một control
		/// </summary>
		/// <param name="control">Control cần được thêm mách nước</param>
		/// <param name="caption">Dòng chữ mách nước</param>
		public void SetToopTip(Control control, string caption)
		{
			tip.SetToolTip(control, caption);
		}

		/// <summary>
		/// Lấy mách nước của một control
		/// </summary>
		/// <param name="control">Control cần lấy mách nước</param>
		/// <returns>Dòng chữ mách nước</returns>
		public string GetTooltip(Control control)
		{
			return tip.GetToolTip(control);
		}

		#endregion
	}
}
