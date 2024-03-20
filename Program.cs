

class Operation
{

    // Method to add two numbers
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

    // Method to subtract two numbers
    public int Subtract(int firstNumber, int secondNumber)
    {
        return firstNumber - secondNumber;
    }

    // Method to multiply two numbers
    public int Multiply(int firstNumber, int secondNumber)
    {
        return firstNumber * secondNumber;
    }

    // Method to divide two numbers
    public int Divide(int firstNumber, int secondNumber)
    {
        return firstNumber / secondNumber;
    }

    public static void Main()
    {
        Operation operation = new Operation();

        Console.Write("Enter the first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.Write("Choose an operation: \n");
        Console.Write("1. Addition  \n");
        Console.Write("2. Subtraction  \n");
        Console.Write("3. Multiplication  \n");
        Console.Write("4. Division  \n\n");

        Console.Write("Enter the operation number (1-4):");

        // Use null-coalescing operator to provide firstNumber default value of an empty string if the input is null.
        string operationNumber = Console.ReadLine() ?? "";

        //Switch case to perform different operations
        switch (operationNumber)
        {
            case "1":
                Console.WriteLine("Result of Addition: {0}", operation.Add(firstNumber, secondNumber));
                break;
            case "2":
                Console.WriteLine("Result of Subtraction: {0}", operation.Subtract(firstNumber, secondNumber));
                break;
            case "3":
                Console.WriteLine("Result of Multiplication: {0}", operation.Multiply(firstNumber, secondNumber));
                break;
            case "4":
                // Check if the second number is zero
                if (secondNumber == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                Console.WriteLine("Result of Division:  {0}", operation.Divide(firstNumber, secondNumber));

                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }


    }

}

