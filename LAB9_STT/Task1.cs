//using System;
//class Calculator
//{
//    public double Add(double a, double b)
//    {
//        return a + b;
//    }
//    public double Subtract(double a, double b)
//    {
//        return a - b;
//    }
//    public double Multiply(double a, double b)
//    {
//        return a * b;
//    }
//    public double Divide(double a, double b)
//    {
//        if (b == 0)
//        {
//            throw new DivideByZeroException("Division by zero is not allowed.");
//        }
//        return (double)a / b;
//    }
//}

//class Task1
//{
//    static void Main(string[] args)
//    {
//        Calculator calculator = new Calculator();
//        Console.Write("Enter first number: ");
//        double num1 = Convert.ToDouble(Console.ReadLine());
//        Console.Write("Enter second number: ");
//        double num2 = Convert.ToDouble(Console.ReadLine());
//        try
//        {
//            Console.WriteLine($"{num1}+{num2}: {calculator.Add(num1, num2)}");
//            if (calculator.Add(num1, num2) % 2 == 0)
//            {
//                Console.WriteLine("The sum is Even\n");
//            }
//            else
//            {
//                Console.WriteLine("The sum is Odd\n");
//            }
//            Console.WriteLine($"{num1}-{num2}: {calculator.Subtract(num1, num2)}\n");
//            Console.WriteLine($"{num1}*{num2}: {calculator.Multiply(num1, num2)}\n");
//            Console.WriteLine($"{num1}/{num2}: {calculator.Divide(num1, num2)}\n");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//        Console.WriteLine();
//    }
//}