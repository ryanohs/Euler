namespace Euler
{
	public static class Factorial
	{
		public static long For(long i)
		{
			long factorial = 1;
			while(i > 1)
			{
				factorial = factorial * i--;
			}
			return factorial;
		}
	}
}