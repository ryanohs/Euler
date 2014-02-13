namespace Euler
{
	using System.Collections.Generic;
	using System.Threading.Tasks;

	public class PrimeNumbers
	{
		public static IEnumerable<long> Sequence()
		{
			yield return 2;
			long i = 3;
			while (true)
			{
				if (FermatFactorization.IsPrime(i))
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
			while (true)
			{
				var isPrimeCandidate = true;
				Parallel.ForEach(primes, (n, state) =>
				                         	{
				                         		if (i%n == 0)
				                         		{
				                         			state.Stop();
				                         			isPrimeCandidate = false;	// I'm not 100% sure I can actually set this after Stop() but it passed problems 7 & 10
				                         		}
				                         	});
				if (isPrimeCandidate)
				{
					primes.Add(i);
					yield return i;
				}
				i += 2;
			}
		}
	}
}