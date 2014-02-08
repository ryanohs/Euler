namespace Euler
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public static class FermatFactorization
	{
		public static long[] Of(long n)
		{
			var factors = new List<long>();
			while(n%2==0)
			{
				factors.Add(2);
				n = n/2;
			}
			Recurse(n, factors);
			return factors.OrderByDescending(x => x).ToArray();
		}

		public static bool IsPrime(long n)
		{
			var firstStep = Step(n);
			return firstStep.Length == 1;
		}

		private static void Recurse(long n, List<long> factorsFound)
		{
			var result = Step(n);
			if (result.Length == 1)
			{
				factorsFound.Add(result[0]);
			}
			else
			{
				Recurse(result[0], factorsFound);
				Recurse(result[1], factorsFound);
			}
		}

		private static long[] Step(long n)
		{
			long a = Convert.ToInt64(Math.Ceiling(Math.Sqrt(n)));
			long b2 = a*a - n;
			double b = Math.Sqrt(b2);
			while (b%1 != 0) // while b has decimal part
			{
				a++;
				b2 = a*a - n;
				b = Math.Sqrt(b2);
			}
			if (a + b == n) // factors are 1 and n
			{
				return new[] {n};
			}
			return new[] {Convert.ToInt64(a + b), Convert.ToInt64(a - b)};
		}
	}
}