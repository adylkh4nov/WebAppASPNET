namespace WebApp.Models
{
	
	public interface IMessage
	{
		string Email { get; set; }
		string Fullname { get; set; }
		string Company { get; set; }

		decimal Budget { get; set; }

		string MessageText {  get; set; }
		
	}
}
