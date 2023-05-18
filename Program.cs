using System;

class Program
{
    static void Main()
    {
        bool validInput = false;
        while (!validInput)
        {
            Console.Write("Enter a character (+/- to continue, any other character to exit): ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (inputChar == '+' || inputChar == '-')
            {
                Console.Write("Enter the size of the matrix: ");
                if (int.TryParse(Console.ReadLine(), out int size))
                {
                    Console.Write("Enter a real number: ");
                    if (double.TryParse(Console.ReadLine(), out double number))
                    {
                        Console.WriteLine();

                        if (inputChar == '+')
                        {
                            double result = size + number;
                            Console.WriteLine("Matrix sum: " + result);
                        }
                        else
                        {
                            double result = size - number;
                            Console.WriteLine("Matrix subtraction: " + result);
                        }

                        continue;
                    }
                }
            }

            validInput = true;
        }
    }
}

