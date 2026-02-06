using System;

class ArithmeticCalculator
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            return double.NaN;
        }
        return a / b;
    }

    static void Main(string[] args)
    {
        char choice = 'Y';

        while (choice == 'Y' || choice == 'y')
        {
            Console.WriteLine("Press any following key to perform an arithmetic operation:");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");

            int operation;
            if (!int.TryParse(Console.ReadLine(), out operation))
            {
                Console.WriteLine("Invalid input! Please enter a number between 1 and 4.");
                continue;
            }

            Console.Write("Enter Value 1: ");
            double value1;
            if (!double.TryParse(Console.ReadLine(), out value1))
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
                continue;
            }

            Console.Write("Enter Value 2: ");
            double value2;
            if (!double.TryParse(Console.ReadLine(), out value2))
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
                continue;
            }

            double result = 0;
            string operatorSymbol = "";

            switch (operation)
            {
                case 1:
                    result = Add(value1, value2);
                    operatorSymbol = "+";
                    break;
                case 2:
                    result = Subtract(value1, value2);
                    operatorSymbol = "-";
                    break;
                case 3:
                    result = Multiply(value1, value2);
                    operatorSymbol = "*";
                    break;
                case 4:
                    result = Divide(value1, value2);
                    operatorSymbol = "/";
                    break;
                default:
                    Console.WriteLine;

            }
        }
    }
}
