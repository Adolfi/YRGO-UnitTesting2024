namespace YrgoTesting.Tests.Lab51
{
	public class GreetingService
	{
		public string GetGreeting(IUser user)
		{
			return $"Welcome {user.FirstName} {user.LastName}! Have a great day!";
		}
	}

	public interface IUser
	{
		string FirstName { get; }
		string LastName { get; }
	}
}
