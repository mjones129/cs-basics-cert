//This is code project number 1 in unit 5 of the C# course

Console.WriteLine("Enter an integer value between 5 and 10");

while (true)
{
    string input = Console.ReadLine();
    int value;
    if (int.TryParse(input, out value))
    {
        if (value >= 5 && value <= 10)
        {
            Console.WriteLine("Your input value (" + value + ") has been accepted.");
            break;
        }
        else
        {
            Console.WriteLine("You entered (" + value + ") Please enter a value between 5 and 10");
        }
    }
    else
    {
        Console.WriteLine("Please enter a valid integer value");
    }
}