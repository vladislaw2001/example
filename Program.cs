using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Яке найменше додатне число ділиться на всі числа від 1 до 10?

namespace Ivan
{
    internal class Program
    {

        static void Krat(int a)
        {
            bool start = true;
            ulong count = 0;
            while (start)
            {
                for (int i = 1; i < 11; i++)
                {
                    if (a % i != 0)
                    {
                        Krat(a + 1);
                    }
                    else
                    {
                        count++;
                    }

                    if (count == 10)
                    {
                        start = false;
                        Console.WriteLine($"{a} мега число");
                        Console.ReadKey();
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Krat(1);

        }
    }
}
