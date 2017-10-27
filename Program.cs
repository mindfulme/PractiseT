// rought solution 
//Rostislav Gogolauri

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Vx, Vy, x0, y0, x, y, w, h,overH,overW;
            int t;
            Console.WriteLine("Vx= ");
            Vx = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vy= ");
            Vy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x0= ");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y0= ");
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("t= ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("W= ");
            w = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("H= ");
            h = Convert.ToDouble(Console.ReadLine());
            x = x0;
            y = y0;
            if (x0 <= 0 || y0 <= 0 || x0 > w || y0 > h)
            {
                Console.Write("Are you kidding?");
            }
            else
            {
                for (int i = 0; i <= t; i++)
                {
                    x = x + Vx;
                    y = y + Vy;
                    if (x <= 0 && y <= 0)
                    {   //
                        overH = Math.Abs(y);
                        overW = Math.Abs(x);
                        x = 0+overW;
                        Vx = -Vx;
                        //

                        y = 0+overH;
                        Vy = -Vy;
                        //

                    }
                    else if (x <= 0 && y > 0 &&y<=h)
                    {   //
                        overW = Math.Abs(x);
                        x = 0 + overW;
                        Vx = -Vx;
                        //

                    }
                    else if (x <= 0 && y >= h)
                    {   //
                        overW = Math.Abs(x);
                        overH = y - h;
                        x = 0+overW;
                        Vx = -Vx;
                        //
                        y = h-overH;
                        Vy = -Vy;

                    }
                    else if (x > 0 && y <= 0)
                    {   //
                        overH = Math.Abs(y);
                        y = 0+overH;
                        Vy = -Vy;
                        //

                    }
                    else if (x >= w && y <= 0)
                    {   //
                        overH = Math.Abs(y);
                        y = 0+overH;
                        Vy = -Vy;
                        //
                        x = w;
                        Vx = -Vx;
                    }
                    else if (y >= h && x >= w)
                    {   //
                        overH = y - h;
                        overW = x - w;
                        y = h-overH;
                        Vy = -Vy;
                        //

                        x = w-overW;
                        Vx = -Vx;
                    }
                    else if (x>=w && y>=0)
                    {
                        overW = x - w;
                        Vx = -Vx;
                        x = w-overW;
                    }
                    else if (y >= h && x >= 0)
                    {
                        overH = y - h;
                        Vy = -Vy;
                        y = h-overH;
                    }
                    Console.WriteLine("i={0} ", i);
                    Console.Write("x={0} ", x);
                    Console.Write("y={0} ", y);

                }
            }
            Console.ReadKey();
        }
    }
}

