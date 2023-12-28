using System;

class Program
{
    static double piValue = Math.PI;

    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            string userInput = Console.ReadLine()?.ToLower();

            switch (userInput)
            {
                case "1":
                    AreaOfSquare();
                    break;

                case "2":
                    AreaOfRectangle();
                    break;

                case "3":
                    AreaOfCircle();
                    break;

                case "q":
                    ExitProgram();
                    return;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Console Application Menu");
        Console.WriteLine("1. Area of Square.");
        Console.WriteLine("2. Area of Rectangle.");
        Console.WriteLine("3. Area of Circle.");
        Console.WriteLine("Q. Quit");
        Console.Write("Enter your choice: ");
    }

    static void AreaOfSquare()
    {
        Console.WriteLine("You selected option 1.");
        Console.Write("Enter Length: ");
        if (double.TryParse(Console.ReadLine(), out double length))
        {
            Console.WriteLine($"Area of Square is: {length * length}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
    }

    static void AreaOfRectangle()
    {
        Console.WriteLine("You selected option 2.");
        Console.Write("Enter Width: ");
        if (double.TryParse(Console.ReadLine(), out double width))
        {
            Console.Write("Enter Height: ");
            if (double.TryParse(Console.ReadLine(), out double height))
            {
                double area = width * height;
                Console.WriteLine($"Area of Rectangle is: {area}");
            }
            else
            {
                Console.WriteLine("Invalid input for height. Please enter a valid numeric value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for width. Please enter a valid numeric value.");
        }
    }

    static void AreaOfCircle()
    {
        Console.WriteLine("You selected option 3.");
        Console.Write("Enter radius: ");
        if (double.TryParse(Console.ReadLine(), out double radius))
        {
            double area = piValue * radius * radius;
            Console.WriteLine($"Area of Circle is: {area}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid numeric value.");
        }
    }

    static void ExitProgram()
    {
        Console.WriteLine("Exiting the program. Goodbye!");
        Environment.Exit(0);
    }
}
