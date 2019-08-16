using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleNumbers
{
    static class TriangleJava
    {
        public static int getInt()
        {
            String s = getString();
            return Int32.Parse(s);
        }
        public static String getString()
        {
            String s = Console.ReadLine();
            return s;
        }
    }
}
