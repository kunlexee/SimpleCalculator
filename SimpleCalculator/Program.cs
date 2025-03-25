using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A very simple calculator");
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("\n List of Operations");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");

            Console.WriteLine("Choose from the list displayed");
            string choice = Console.ReadLine();
        
            var menuActions = new Dictionary<string, Action>()
            {
                { "1", Addition },
                { "2", Subtraction },
                { "3", Multiplication },
                { "4", Division },
                { "5", Exit }
            };

            if (menuActions.ContainsKey(choice))
            {
                menuActions[choice].Invoke();
            }
            else
            {
                Console.WriteLine("Invalid choice! Please try again");
                ShowMenu();
            }
        }

        static void Addition()
        {
            Console.WriteLine("\n Addition ");
            double num1 = GetNumber("Enter first number: ");
            double num2 = GetNumber("Enter second number: ");
            double result = num1 + num2;
            Console.WriteLine($"Result: {num1} + {num2} = {result}");

            ShowMenu();
        }

        static void Subtraction()
        {
            Console.WriteLine("\n subtraction");
            double num1 = GetNumber("Enter first number: ");
            double num2 = GetNumber("Enter second Number: ");
            double result = num1 - num2;  
            Console.WriteLine($"Result: {num1} - {num2} = {result}");
            ShowMenu();
        }

        static void Multiplication()
        {
            Console.WriteLine("\n Multiplication");
            double num1 = GetNumber("Enter first number: ");
            double num2 = GetNumber("Enter second Number: ");
            double result = num1 * num2;
            Console.WriteLine($"Result: {num1} * {num2} = {result}");
            ShowMenu();
        }

        static void Division()
        {
            double num1 = GetNumber("Enter First number: ");
            double num2 = GetNumber("Enter second number (not zero): ");

            if (num2 == 0)
            {
                Console.WriteLine("Error: cannot divide by zero!");
            }
            else
            {
                double result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            ShowMenu();
        }

        static void Exit()
        {
            Console.WriteLine("Thanks for using me");
            Environment.Exit(0);
        }

        static double GetNumber(string prompt)
        {
            double number;
            Console.Write(prompt);
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Invalid input. Please enter valid number:");
            }
            return number;
        }
    }
}
