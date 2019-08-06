namespace QuanLyQuanCafe
{
	public static class Bcrypt
	{
		private static string getRandomSalt()
		{
			return BCrypt.Net.BCrypt.GenerateSalt(12);
		}

		/// <summary>
		/// Mã hóa mật khẩu bằng cách băm bằng thuật toán BCrypt
		/// </summary>
		/// <param name="password">Mật khẩu ban đầu</param>
		/// <returns>Mật khẩu được mã hóa</returns>
		public static string HashPassword(string password)
		{
			return BCrypt.Net.BCrypt.HashPassword(password, getRandomSalt());
		}

		/// <summary>
		/// Xác nhận tính đúng đắn giữa một mật khẩu thô và mật khẩu được mã hóa
		/// </summary>
		/// <param name="password">Mật khẩu cần được kiểm chứng</param>
		/// <param name="correctHash">Mật khẩu kiểm chứng được mã hóa</param>
		/// <returns>True nếu 2 mật khẩu khớp, False nếu không khớp</returns>
		public static bool ValidatePassword(string password, string correctHash)
		{
			return BCrypt.Net.BCrypt.Verify(password, correctHash);
		}
	}
}
