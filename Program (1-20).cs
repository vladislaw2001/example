using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//Яке найменше додатне число ділиться на всі числа від 1 до 20?
namespace Trash
{

    internal class Program
    {
        public static void Kratne(long number)
        {
            bool Kran = true;
            int counter = 1;
            while (Kran)
            {
                if (number % counter == 0 && counter != 21)
                {
                    counter++;
                }
                else
                {
                    if (counter == 21)
                    {
                        Kran = false;
                    }
                    else
                    {
                        counter = 1;
                        number += 10;
                    }
                }

            }
            Console.WriteLine($"{number} ділиться на всі 20 чисел");
        }
        static void Main(string[] args)
        {

            Kratne(10);


            Console.ReadKey();
        }

    }
}
