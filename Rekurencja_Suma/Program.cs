
using System;

namespace Rekurencja_Suma
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] arr=new int[] {2,4,3,4,6};
			int res = suma(arr);
			Console.WriteLine(res);
			Console.ReadLine();
		}
		
		public static int suma(int[] x)
		{
			int i=0;
			if(x[i]==null)
			{
				return x[i];
			}
			else
			{
				return suma(x[i])+suma(x[i+1]);
			}
		}
	}
}