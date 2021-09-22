using System;

namespace Calculater
{
    class MainClass
    {
        
        public static void Main(string[] args)
        {
            bool running = true;
            double num1 = 0; double num2 = 0;
            double userInput;

            Console.WriteLine("Welcome To My Calculater!");
            Console.WriteLine("-------------------------");
            Console.WriteLine();


            Console.WriteLine("Do you want to start? 1 for Yes");
            userInput = GetNumberFromUser();
            if (userInput == 1)
            {
                running = true;
            }

            while (running)
            {

                Console.Clear();
                Console.WriteLine("Type a number then press Enter");
                num1 = GetNumberFromUser();

                Console.WriteLine("Type another number then press Enter");
                num2 = GetNumberFromUser();

                Console.WriteLine("Choose an option from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("Your option? ");

                switch(Console.ReadLine())
                {
                    case "a":
                        Add(num1, num2);
                        PressAnyKey();
                        break;
                    case "s":
                        Subtract(num1, num2);
                        PressAnyKey();
                        break;
                    case "m":
                        Multiply(num1, num2);
                        PressAnyKey();
                        break;
                    case "d":
                        Divide(num1, num2);
                        PressAnyKey();
                        break;
                    default:
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Do you want to quit? 1 for yes");

                userInput = GetNumberFromUser();
                if (userInput == 1)
                {
                    running = false;
                }

                Console.Clear();

            }

        }

        static double GetNumberFromUser()
        {
            double userInput = 0;
            bool succeeded = false;

            while (!succeeded)
            {
                succeeded = double.TryParse(Console.ReadLine(), out userInput);

            }
            return userInput;
        }

        static void PressAnyKey()
        {
            Console.Write("Press any key to continue...");
            ConsoleKeyInfo inputKey  = Console.ReadKey();
            return;
        }

        static void Add(double num1,double num2)
        {
            Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
            return; 
        }

        static void Subtract(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
            return;
        }

        static void Multiply(double num1, double num2)
        {
            Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
            return;
        }

        static void Divide(double num1, double num2)
        {
            while (num2 == 0)
            {
                Console.WriteLine("Enter a non-zero divisor: ");
                Console.WriteLine();
                num2 = GetNumberFromUser();
            }
            Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
            return;
        }

    }
}
