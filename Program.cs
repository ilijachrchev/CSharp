﻿using System;

namespace MyFirstCalculator {

    class Program {
        static void Main(string[] args)
        {
            
            do {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("-------------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("-------------------");

            Console.WriteLine("Enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter an option: ");
            Console.WriteLine("\t+ : Add");
            Console.WriteLine("\t- : Substract");
            Console.WriteLine("\t* : Multiply");
            Console.WriteLine("\t/ : Divide");
            Console.Write("Enter an option: ");




            switch (Console.ReadLine()) {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Your Result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Your Result: {num1} - {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Your Result: {num1} / {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Your Result: {num1} * {num2} = " + result);
                    break;

                default:
                    Console.WriteLine("That was not a valid option");
                    break;
            }
            Console.WriteLine("Would you like to continue? (Y/N): ");
            } while(Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}