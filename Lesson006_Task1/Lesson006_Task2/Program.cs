using System;

namespace Lesson006_Task2
{
    class MainClass
    {
        static void iAnd ( int a,  int b)
        {
            int res = a & b;
            Console.WriteLine($"And={res}");
            
        }
        static void iOr( int a,  int b)
        {
            int res = a | b;
            Console.WriteLine($"Or={res}");
            
        }
        static void iEOR( int a,  int b)
        {
            int res = a ^ b;
            Console.WriteLine($"EOr={res}");
            
        }
        static void iNotA(int a)
        {
            int res = ~a;
            Console.WriteLine($"Not A ={res}");
        }
        static void iNotb(int b)
        {
            int res = ~b;
            Console.WriteLine($"Not B ={res}");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter B:");
            string b = Console.ReadLine();
            int iA = int.Parse(a);
            int iB = int.Parse(b);
            Console.WriteLine("Enter Operation (&,|,^,~A,~B):");
            string operation = Console.ReadLine();
            if (operation == "&")
            {
                iAnd( iA,  iB);
            }
            else if(operation == "|")
            {
                iOr( iA,  iB);
            }
            else if (operation == "^")
            {
                iEOR( iA,  iB);
            }
            else if (operation == "~A")
            {
                iNotA(iA);
            }
            else if (operation == "~B")
            {
                iNotb(iB);
            }
            else
            {
                Console.WriteLine("Wrong operation");
            }
            
        }
    }
}
