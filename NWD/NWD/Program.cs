using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                string readtemp = Console.ReadLine();
                string[] tabtemp = readtemp.Split(' ');
                int a = Convert.ToInt32(tabtemp[0]);
                int b = Convert.ToInt32(tabtemp[1]);
                Console.WriteLine(nwd(a, b));
            }
        }

        public static int nwd(int a, int b)
        {
            int nwd=1;
            int temp;

            while (a != b)
            {
                if (a < b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }

                nwd = a - b;

                if (nwd == b)
                    break;
                else
                    a = nwd;
            }
            return nwd;
        }
    }
}
