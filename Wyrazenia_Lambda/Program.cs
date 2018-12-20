
using System;

namespace Wyrazenia_Lambda
{
	class Program
	{
		
		
		
		public static void Main(string[] args)
		{
//			Func<int,int,int> lam = (int a, int b)=>
//			{
//				return a*b;
//			};
//			
//			Console.WriteLine(lam(9,7));
			
			TestFun.wieksze(1);
			Console.ReadLine();
		}
	}
	
	class TestFun
	{
		public static Func<int,bool> TestLam(int a){
			return b=> b>a;
		}
		
		public static void wieksze(int b)
		{
			var funkcja = TestLam(10);
			Console.WriteLine(funkcja(b));
		}
	}
}