using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNumbers
{
    class Program
    {
        static int theNumber;

        static void Main(string[] args)
        {
            JavaStart();
            Line("--------------------------------------");
            RecStart();
            Line("--------------------------------------");
            NoRec();
        }

        public static void Line(string s) => Console.WriteLine(s);

        public static void JavaStart()
        {
            Console.Write("Enter a number: ");
     
            theNumber = TriangleJava.getInt();
            int theAnswer = triangle(theNumber);
            Console.WriteLine("Triangle=" + theAnswer);
        }

        static void RecStart()
        {
            int num = 8;
            int result = Rec(num);
            Console.WriteLine($" = {result}\n");
        }

        public static int triangle(int n)
        {
            if (n == 1)
                return 1;
            else
                return (n + triangle(n - 1));
        }

        static int Rec(int num)
        {
            Console.Write($"значение num - {num}\n");
            if (num == 1)
            {
                return 1;
            }
            else
            {
                int r = Rec(num-1) + num;
                Console.Write($"Сумма r - {r}\n");
                return r;
            }
        }

        static void NoRec()
        {
            List<int> result = new List<int>();
            int num = 8;
            while (num > 0)
            {
                result.Add(num--);
            }
            Console.Write(string.Join("+", result));
            Console.Write($" = {result.Sum()}\n");
        }
    }
}
