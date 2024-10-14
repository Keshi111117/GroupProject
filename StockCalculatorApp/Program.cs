using System;

class StockCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Stock Calculator");
        Console.WriteLine("How many numbers would you like to add? (2 or 3)");
        
        // Get the number of inputs (either 2 or 3)
        int numberOfInputs = int.Parse(Console.ReadLine());

        // Ensure the user enters either 2 or 3
        if (numberOfInputs != 2 && numberOfInputs != 3)
        {
            Console.WriteLine("Please enter 2 or 3 numbers only.");
            return;
        }

        // Collect the numbers to add
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        double num3 = 0;
        if (numberOfInputs == 3)
        {
            Console.WriteLine("Enter the third number:");
            num3 = double.Parse(Console.ReadLine());
        }

        // Perform addition
        double result = AddNumbers(num1, num2, num3, numberOfInputs);
        
        // Display result
        Console.WriteLine($"The result is: {result}");
    }

    // Function to add 2 or 3 numbers based on the input count
    static double AddNumbers(double num1, double num2, double num3, int numberOfInputs)
    {
        if (numberOfInputs == 2)
        {
            return num1 + num2;
        }
        else
        {
            return num1 + num2 + num3;
        }
    }
}
