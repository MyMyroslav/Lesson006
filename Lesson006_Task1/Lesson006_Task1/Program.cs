using System;

namespace Lesson006_Task1
{
    class MainClass
    {
        static void CalculateIncrement(ref int a)
        {
            int res = ++a;
            Console.WriteLine(res);
        }
        static void CalculateDecrement(ref int a)
        {
            int res = a--;
            Console.WriteLine(res);
        }
        public static void Main(string[] args)
        {
            int a = 12;
            CalculateDecrement(ref a);
            CalculateIncrement(ref a);
            
        }
    }
}
