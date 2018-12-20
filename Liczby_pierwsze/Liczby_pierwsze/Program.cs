using System;

namespace Liczby_pierwsze
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
		
			for (int i=0;i<n;i++)
			{
				if (czyPierwsza(int.Parse(Console.ReadLine()))==true)
					Console.WriteLine("TAK");
				else
					Console.WriteLine("NIE");
			}
		}
		
		public static bool czyPierwsza(int n)
		{
			if (n==1)
			{
				return false;
			}
			for (int i = 2;i<(n/2)+1;i++)
			{
				if(n%i==0)
					return false;
			}
			return true;
		}
	}
}