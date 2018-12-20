using System;
using System.Diagnostics;

namespace silnia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Start");
			Console.ReadKey();
			Stopwatch watch = new Stopwatch();
			
			watch.Start();
			int D;
			string ilosc_przypadkow;

			Random rnd = new Random();
			D=rnd.Next(1,30);
			
			
			//Console.WriteLine("Wpisz ilość przypadków:");
			//ilosc_przypadkow=Console.ReadLine();
			//Int32.TryParse(ilosc_przypadkow, out D);
			int[] liczby = new int[D];
			
			//Console.WriteLine("Wpisz liczby do silni:");
			for (int i = 0; i < D; i++) 
			{
				//string x;
				liczby[i]=rnd.Next(10,20);
				//x=Console.ReadLine();
				//Int32.TryParse(x, out liczby[i]);
			}
			
			for (int i = 0; i < liczby.Length; i++) 
			{
				int wynik=1, j=1;
				string y;
				while (liczby[i]>0)
				{
					wynik = liczby[i]*;
					liczby[i]--;
					j++;
				}
				y=wynik.ToString();
				Console.WriteLine(y);
				if (y.Length<2) 
				{
					Console.WriteLine("0" + " " +y[(y.Length-1)]);
				}
				else
				{
					Console.WriteLine(y[(y.Length-2)]+" "+y[(y.Length-1)]);
				}
			}
			watch.Stop();
			
			Console.WriteLine(watch.ElapsedMilliseconds.ToString());
			Console.ReadLine();
		}
	}
}
