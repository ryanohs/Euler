namespace Euler
{
	using System;
	using System.Collections.Generic;

	public static class Matrix
	{
		public static IEnumerable<T> Traverse<T>(int rows, int cols, Func<int, int, T> generator)
		{
			var stripes = 2*Math.Max(rows+1, cols+1) - 1;
			for (int stripe = 1; stripe < stripes; stripe++)
			{
				for (int col = 1; col <= stripe; col++)
				{
					for (int row = stripe; row > stripe-col; row--)
					{
						if ((col + row == stripe + 1) && (col >= row))
						{
							yield return generator(row-1, col-1);
						}
					}
				}
			}
		}
	}
}