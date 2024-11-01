using System;

Console.WriteLine("Enter a number between 5 and 10.");

bool validNumber = false;

do
{
    string? input = Console.ReadLine();
    if (int.TryParse(input, out int num))
    {
        if (num >= 5 && num <= 10)
        {
            validNumber = true;
            Console.WriteLine($"You entered {num} which is between 5 and 10.");
        }
        else
        {
            Console.WriteLine("Your number is not between 5 and 10. Try again.");
        }

    }
    else
    {
        Console.WriteLine("Invalid input. Try again.");
    }
} while (validNumber == false);