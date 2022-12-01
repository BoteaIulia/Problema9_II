using System;

public static class Globals
{
	internal static void Main()
	{
		int n;
		int x;
		int y;
		int ok_crescator = 1;
		int ok_descrescator = 1;
		n = Convert.ToInt32(Console.ReadLine());
		x = Convert.ToInt32(Console.ReadLine());
		for (int i = 1; i < n; i++)
		{
			y = Convert.ToInt32(Console.ReadLine());
			if (x < y)
			{

				ok_descrescator = 0;
			}
			else
			{
				if (x > y)
				{
					ok_crescator = 0;
				}
			}
			x = y;
		}
		if (ok_crescator == 1 || ok_descrescator != 0)
		{
			Console.Write("Secventa este monotona!");
		}
		else
		{
			Console.Write("Secventa nu este monotona!");
		}
	}
}
