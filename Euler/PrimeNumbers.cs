namespace Euler
{
	using System.Collections.Generic;

	public class PrimeNumbers
	{
		public static IEnumerable<long> Sequence()
		{
			yield return 2;
			long i = 3;
			while(true)
			{
				if(FermatFactorization.IsPrime(i))
				{
					yield return i;
				}
				i = i + 2;
			}
		}
	}
}