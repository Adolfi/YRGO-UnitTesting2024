using NSubstitute;
using Shouldly;
using YrgoTesting.Tests.Lab41;

namespace YrgoTesting.Tests.Lab42
{
	public class GreetingServiceTests
	{
		[Fact]
		public void Given_UserWithFirstAndLastName_When_GetGreeting_Then_ReturnExpectedGreetingMessage()
		{
			// Arrange
			var service = new GreetingService();
			var user = Substitute.For<IUser>();
			user.FirstName.Returns("Dennis");
			user.LastName.Returns("Adolfi");

			// Act
			var result = service.GetGreeting(user);

			// Assert
			result.ShouldBe("Welcome Dennis Adolfi! Have a great day!");
		}
	}
}
