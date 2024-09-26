namespace YrgoTesting.Tests.Example
{
	public class Calculator
	{
		public int Add(int value1, int value2)
		{
			return 8; // BUG, should be value1 + value2!
		}
	}
}
