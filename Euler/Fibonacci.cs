namespace Euler
{
	using System.Collections.Generic;

	public static class Fibonacci
	{
		public static IEnumerable<long> Sequence()
		{
			yield return 1;
			yield return 2;
			var nMinus2 = 1L;
			var nMinus1 = 2L;
			while (true)
			{
				var n = nMinus1 + nMinus2;
				yield return n;
				nMinus2 = nMinus1;
				nMinus1 = n;
			}
		}
	}
}