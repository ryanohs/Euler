namespace Euler
{
	using System.Linq;

	public static class Palindrome
	{
		public static bool Test(int i)
		{
			var str = i.ToString();
			return str.Equals(new string(str.Reverse().ToArray()));
		}
	}
}