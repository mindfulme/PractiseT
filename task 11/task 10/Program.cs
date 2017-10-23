using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,max;
            int[] set = new int[100];

            Console.WriteLine
                ("Enter number of elements in the set");
            number = Convert.ToInt32(Console.ReadLine());
            if (number > 100)
            {
                Console.WriteLine("The number more than 100");
            }
            else
            {
                for (int i = 0; i < number; i++)
                {
                    set[i] = Convert.ToInt32(Console.ReadLine());
                }
                max = set[0];
                for (int i=0;i<number;i++)
                {
                    
                    if (set[i] > set[0])
                    {
                        max = set[i];
                    }
                  
                }
               Console.Write(Convert.ToString(max));


            }

            
            Console.ReadKey();
        }
    }
}
