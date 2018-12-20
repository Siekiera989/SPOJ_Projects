
using System;

namespace Rekurencja
{
	class Program
	{
		public static void Main(string[] args)
		{
			double x=6;
			countdown(x);
			Console.ReadLine();
		}
		
		static public void countdown(double x)
		{
			if (x>=0)
			{
			Console.WriteLine(x);
			countdown(x-1);
			}
		}
	}
}