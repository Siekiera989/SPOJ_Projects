using System;

namespace Flamaster
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Podaj wyraz:");
			string ciag_znakow=Console.ReadLine();
			char[] tabChar = ciag_znakow.ToCharArray();
			string finalString="";
						
			for (int i =0;i<tabChar.Length;i++) //wyszukaj każdy element tablicy
			{
				if (tabChar[i]!='0')
				{
					int count=1;
					for (int j=i+1; j<tabChar.Length; j++) 
					{						
						if (tabChar[i]==tabChar[j])
						{
							count++;
							tabChar[j]='0';
						}
						
					}
						string countStr=count.ToString(); //przerobienie liczebnika na stringa
						
						if (countStr=="1") //jeśli jedno wystąpienie to wyczyść stringa
							countStr=String.Empty;
						
						finalString+=tabChar[i]+countStr; // zbudowanie stringa
						tabChar[i]='0';
				}
			}
		Console.WriteLine(finalString);
		Console.ReadKey();
		}
	}			
}		