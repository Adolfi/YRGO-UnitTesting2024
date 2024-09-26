using Shouldly;

namespace YrgoTesting.Tests.Lab3
{
	public class UnitTest3
	{
		[Fact]
		public void Given_SomeString_When_ToUpper_Then_ShouldBeUppercase()
		{
			// Arrange
			var someVariable = "Some String Value";

			// Act
			someVariable = someVariable.ToUpper();

			// Assert
			someVariable.ShouldBe("SOME STRING VALUE");
		}
	}
}