using Shouldly;

namespace YrgoTesting.Tests.Lab4
{
	public class UnitTest4
	{
		[Theory]
		[InlineData("Some String Value", "SOME STRING VALUE")]
		[InlineData("Some Other Value", "SOME OTHER VALUE")]
		[InlineData("Hello Yrgo", "HELLO YRGO")]
		public void Given_SomeString_When_UsingToUpper_Then_StringIsUppercase(string input, string expected)
		{
			// Act
			input = input.ToUpper();

			// Assert
			input.ShouldBe(expected);
		}
	}
}