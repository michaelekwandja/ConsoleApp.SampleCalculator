


public class Utility
{
    public static int choice { get; set; }
    public static int num1 { get; set; }
    public static int num2 { get; set; }
    public static int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }

    public static int SubtractNumbers(int num1, int num2)
    {
        return num1 - num2;
    }

    public static int Product(int num1, int num2)
    {
        return num1 * num2;
    }

    public static int Quotient(int num1, int num2)
    {
        return num1 / num2;
    }


    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("******** - Welcome to the sample calculator! - ********");
        Console.WriteLine("Please select an operation (-1 to exit program) ");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
    }
}