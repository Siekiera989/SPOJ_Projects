using System;

namespace proste_dodawanie
{
	class Program
	{
		public static void Main(string[] args)
		{
			int t = int.Parse(Console.ReadLine()); // liczba testów
		
			for (int i=0;i<t;i++)
			{
				string number =Console.ReadLine();
				bool isOK=false;
				int step=0;
				while (isOK==false) 
				{
					
					string palidrom="";
					for (int j = 0; j < number.Length; j++) // utworznie palidromu z liczby
					{
						palidrom+=number[number.Length-j-1];
                        if (palidrom[j] == number[j])
                            isOK = true;
                        else
                            isOK = false;
					}
					if (isOK==false)
					{
						int suma= Convert.ToInt32(number)+Convert.ToInt32(palidrom);
						number=suma.ToString();
						step++;
					}
				}
				Console.WriteLine(number+" "+step.ToString());
			}
		}
	}
}
