namespace Euler
{
	using System;
	using System.Collections.Generic;

	public static class Matrix
	{
		public static IEnumerable<T> Traverse<T>(int rows, int cols, Func<int, int, T> generator)
		{
			var stripes = rows + cols - 1;
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

		public static void HorizontalMatch(int[][] matrix, int x, int y, int length, Action<int[]> action)
		{
			for (int i = 0; i < y; i++)
			{
				for (int j = 0; j < x-length; j++)
				{
					action(new[] {matrix[i][j], matrix[i][j + 1], matrix[i][j + 2], matrix[i][j + 3]});
				}
			}
		}

		public static void VerticalMatch(int[][] matrix, int x, int y, int length, Action<int[]> action)
		{
			for (int i = 0; i < y - length; i++)
			{
				for (int j = 0; j < x; j++)
				{
					action(new[] { matrix[i][j], matrix[i+1][j], matrix[i+2][j], matrix[i+3][j] });
				}
			}
		}

		public static void LeftDiagonalMatch(int[][] matrix, int x, int y, int length, Action<int[]> action)
		{
			for (int i = 0; i < y - length; i++)
			{
				for (int j = 0; j < x - length; j++)
				{
					action(new[] { matrix[i][j], matrix[i + 1][j+1], matrix[i + 2][j+2], matrix[i + 3][j+3] });
				}
			}
		}

		public static void RightDiagonalMatch(int[][] matrix, int x, int y, int length, Action<int[]> action)
		{
			for (int i = length-1; i < y; i++)
			{
				for (int j = 0; j < x - length; j++)
				{
					action(new[] { matrix[i][j], matrix[i-1][j + 1], matrix[i -2][j + 2], matrix[i -3][j + 3] });
				}
			}
		}
	}
}