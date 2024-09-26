using Shouldly;

namespace YrgoTesting.Tests.Example
{
	public class CalculatorTests
	{
		[Fact]
		public void Given_TwoValues_When_Add_ExpectResult()
		{
			// Arrange
			var calculator = new Calculator();

			// Act
			var actual = calculator.Add(6, 2);

			// Assert
			actual.ShouldBe(8);
		}

		[Theory]
		[InlineData(2, 6, 8)]
		[InlineData(8, 5, 13)]
		[InlineData(3, 9, 12)]
		public void Given_Values_When_Add_ExpectResult(int x, int y, int expected)
		{
			// Arrange
			var calculator = new Calculator();

			// Act
			var actual = calculator.Add(x, y);

			// Assert
			actual.ShouldBe(expected);
		}
	}
}
