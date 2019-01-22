using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collatz_Conjecture_Algorithm
{
    class Program
    {
        static int even(int num)
        { 
            return num / 2;
        }

        static int odd(int num)
        {
            return num * 3 + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Collats Conjecture Algorithm\n");
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("Please enter a number greater than 1: ");
            string num = Console.ReadLine();
            int numint = Convert.ToInt32(num);

            if(Convert.ToInt32(num) > 1)
            {
                while(numint != 1)
                {
                    if (numint % 2 == 0)
                    {
                        numint = even(numint);
                        Console.WriteLine(numint.ToString() + "\n");
                    } else
                    {
                        numint = odd(numint);
                        Console.WriteLine(numint.ToString() + "\n");
                    }
                }

                if(numint == 1)
                {
                    Console.WriteLine("Number is 1 now :)");
                    Console.ReadLine();
                }
            }

            else
            {
                Console.WriteLine("Error: Number should be greater than 1");
                Console.ReadLine();
            }
        }
    }
}
