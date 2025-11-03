//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LAB9_STT
//{
//    class Task2
//    {
//        static double fac(double x)
//        {
//            if (x < 0) throw new ArgumentException("Factorial is not defined for negative numbers.");
//            if (x == 0) return 1;
//            return x * fac(x - 1);
//        }
//        static void Main(string[] args)
//        {
//            for (int i = 1; i <= 10; i++) Console.WriteLine($"{i} ");
//            Console.WriteLine("\n");
//            foreach (int i in Enumerable.Range(1, 10)) Console.WriteLine($"{i} ");
//            Console.WriteLine("\n");
//            string input;
//            do
//            {
//                input = Convert.ToString(Console.ReadLine());
//            } while (input != "exit");
//            Console.WriteLine("\n");
//            Console.WriteLine("Exited");
//            Console.WriteLine("\n");
//            Console.WriteLine("Enter a number to compute its factorial:");
//            double number = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine($"Factorial of {number} is {fac(number)}");
//        }
//    }
//}
