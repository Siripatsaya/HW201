using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            int Pascal = int.Parse(Console.ReadLine());

            while (Pascal < 0)
            {
                if (Pascal < 0)
                {
                    Console.WriteLine("Invalid Pascal’s triangle row number.");
                }
                int Pascal2 = int.Parse(Console.ReadLine());
                Pascal = Pascal2;
            }
            Pascal_s_Triangle(Pascal);

        }
        static void Pascal_s_Triangle(int Pascal)
        {
            int cal = 0, i, j;

            for (i = 0; i <= Pascal; i++)
            {
                for (j = 0; j <= i; j++)
                {
                    if (j == 0 || i == 0)
                    {
                        cal = 1;
                    }
                    else
                    {
                        cal = cal * (i - j + 1) / j;
                    }
                    Console.Write(cal + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
