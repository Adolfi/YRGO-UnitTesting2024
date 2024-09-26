namespace YrgoTesting.Tests.Lab2
{
	public class UnitTest2
	{
		[Fact]
		public void Given_SomeString_When_ToUpper_Then_ShouldBeUppercase()
		{
			// Arrange
			var someVariable = "Some String Value";

			// Act
			someVariable = someVariable.ToUpper();

			// Assert
			Assert.Equal("SOME STRING VALUE", someVariable);
		}

		[Fact]
		public void Given_SomeString_When_ToLower_Then_ShouldBeLowercase()
		{
			// Arrange
			var someVariable = "Some String Value";

			// Act
			someVariable = someVariable.ToLower();

			// Assert
			Assert.Equal("some string value", someVariable);
		}

		[Fact]
		public void Given_SomeString_When_ToReplaceWithOther_Then_ShouldBeOther()
		{
			// Arrange
			var someVariable = "Some String Value";

			// Act
			someVariable = someVariable.Replace("Some", "Other");

			// Assert
			Assert.Equal("Other String Value", someVariable);
		}
	}
}