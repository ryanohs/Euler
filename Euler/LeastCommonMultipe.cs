namespace Euler
{
	public static class LeastCommonMultipe
	{
		public static long Of(long a, long b)
		{
			return (a*b)/GreatestCommonDivisor.Of(a, b);
		}
	}
}