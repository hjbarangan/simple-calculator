

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

        Console.Write("Enter first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());


        Console.Write("Enter symbol(/, + ,- ,*):");

        // Use null-coalescing operator to provide firstNumber default value of an empty string if the input is null.
        string symbol = Console.ReadLine() ?? "";

        //Switch case to perform different operations
        switch (symbol)
        {
            case "+":
                Console.WriteLine("Addition of {0} and {1} is {2}", firstNumber, secondNumber, operation.Add(firstNumber, secondNumber));
                break;
            case "-":
                Console.WriteLine("Subtraction of {0} and {1} is {2}", firstNumber, secondNumber, operation.Subtract(firstNumber, secondNumber));
                break;
            case "*":
                Console.WriteLine("Multiplication of {0} and {1} is {2}", firstNumber, secondNumber, operation.Multiply(firstNumber, secondNumber));
                break;
            case "/":
                Console.WriteLine("Division of {0} and {1} is {2}", firstNumber, secondNumber, operation.Divide(firstNumber, secondNumber));
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }


    }
}

