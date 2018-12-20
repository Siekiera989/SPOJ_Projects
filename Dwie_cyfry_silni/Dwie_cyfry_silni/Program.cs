
using System;

namespace Dwie_cyfry_silni
{
	class Program
	{
		public static void Main(string[] args)
		{
			int D = int.Parse(Console.ReadLine());
			
			for (int i = 0; i < cases; i++) 
			{
				
					int n = int.Parse(Console.ReadLine());
				if (n<10)
				{
					int resultint = silnia(n);
					int jednosci = resultint%10;
					int dziesiatki =(resultint/10)%10;
					Console.WriteLine("{0} {1}",dziesiatki,jednosci);
				}
				else
				{
					Console.WriteLine("0 0");
				}
			}
		}
		
		public static int silnia(int a)
		{
			if (a==1||a==0) 
			{
				return 1;
			}
			else
			{
				return a*silnia(a-1);
			}
		}
	}
}