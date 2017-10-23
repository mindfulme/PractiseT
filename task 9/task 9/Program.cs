using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double num,sqr;
            Console.WriteLine("Enter a number");
           num= Convert.ToDouble(Console.ReadLine());
            if (num<0)
            {
                Console.WriteLine("Number < 0");
            }
            else
            {
                sqr = num / 3;
                for (int i=0;i<32;i++)
                {
                    sqr = (sqr + num / sqr) / 2;
                }
                Console.Write(Convert.ToString(sqr));
            }
            Console.ReadKey();
        }
    }
}
