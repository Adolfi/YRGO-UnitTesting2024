using NSubstitute;
using Shouldly;
using YrgoTesting.Tests.Lab51;

namespace YrgoTesting.Tests.Lab52
{
	public class GreetingServiceTests
	{
		[Theory]
		[InlineData("x", "y", "Welcome x y! Have a great day!")]
		[InlineData("John", "Doe", "Welcome John Doe! Have a great day!")]
		public void Given_UserWithFirstAndLastName_When_GetGreeting_Then_ReturnExpectedGreetingMessage(
			string firstName, string lastName, string expected)
		{
			// Arrange
			var service = new GreetingService();
			var user = Substitute.For<IUser>();
			user.FirstName.Returns(firstName);
			user.LastName.Returns(lastName);

			// Act
			var result = service.GetGreeting(user);

			// Assert
			result.ShouldBe(expected);
		}
	}
}
