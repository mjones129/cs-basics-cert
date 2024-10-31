using System;
using System.Runtime.ExceptionServices;
using System.Xml;

//Fizz Buzz in C# LET'S GOOOOOOOO
// output values 1 to 100, one number per line
// when the current value is divisible by 3, print `Fizz` next to the number
// when the current value is divisible by 5, print `Buzz next to the number
// when the current value is divisible by both 3 and 5, print the term `FizzBuzz` next to the number

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }
}