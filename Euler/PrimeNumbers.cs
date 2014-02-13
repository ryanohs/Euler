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

		public static IEnumerable<long> Sequence_MemoryIntensive()
		{
			var primes = new List<long>();
			primes.Add(2);
			yield return 2;
			var i = 3;
			while(true)
			{
				bool isPrimeCandidate = true;
				foreach (var knownPrime in primes)
				{
					if (i%knownPrime==0)
					{
						isPrimeCandidate = false;
						break;
					}
				}
				if(isPrimeCandidate)
				{
					primes.Add(i);
					yield return i;
				}
				i += 2;
			}
		}
	}
}