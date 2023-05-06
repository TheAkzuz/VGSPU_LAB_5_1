using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static double chek(double x)
        {
            try
            {
                if (x == -7 || x<=-1 || x>= 1)
                {
                    throw new Exception("введено недопустимое значение");
                }
            }

            catch(Exception)
            {
                //Console.Write("t2t2t");
                return -1;
            }
                return 0;
            
        }
        static void Main(string[] args)
        {
            res:
            Console.Write("Print X =");
            double x = double.Parse(Console.ReadLine());
            //Console.Write(x);
            if (chek(x) == -1)
            {
                //Console.Write("lolo");
                goto res;
            }

            double a = x;
           // Console.Write(x);
            double b = (Math.Log(1 - Math.Abs(x)));
            a = Convert.ToDouble((1 / (x + 7))+b);
            Console.WriteLine(Convert.ToString (a));
        }
    }
}
