
int choice = Utility.choice;
int num1 = Utility.num1;
int num2 = Utility.num1;


while (choice != -1)
{
    try
    {
        // Welcome Message
        Utility.Menu();

        choice = Convert.ToInt32(Console.ReadLine());

        if (choice == -1)
        {
            break;
        }

        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());

       
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = Utility.AddNumbers(num1, num2);
                break;
            case 2:
                answer = Utility.SubtractNumbers(num1, num2);
                break;
            case 3:
                answer = Utility.Product(num1, num2);
                break;
            case 4:
                answer = Utility.Quotient(num1, num2);
                break;
            case 5:
                answer = Utility.Fibonnaci(num1, num2);
                break;
            default:
                throw new Exception("Invalid Menu Item Selected.");
        }

        Console.WriteLine($"The result is: {answer}");
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Cannot divide by zero");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Press any key to continue.");
        Console.ReadLine();
    }
}

Console.WriteLine("******** - Thank you for using the sample calculator! - ********");
