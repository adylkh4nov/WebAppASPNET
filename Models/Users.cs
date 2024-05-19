namespace WebApp.Models
{
	public class Users
	{
		public int Id { get; set; }
		public required string Email { get; set; }
		public string Password { get; set; }
		public string Username { get; set; }
	}
}
