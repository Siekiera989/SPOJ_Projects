using System;

namespace potegowanie
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
		
			for (int i=0;i<n;i++)
			{
				string readtemp = Console.ReadLine();
				string[] tabtemp = readtemp.Split(' ');
				double a=Convert.ToDouble(tabtemp[0])%10; //podstawa
				double b=Convert.ToDouble(tabtemp[1])%4; //wykładnik
				if (b==0) 
				{
					b=4;
				}
				double res = Math.Pow(a,b)%10;
				Console.WriteLine(res.ToString());
			}
		}
	}
}