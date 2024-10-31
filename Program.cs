using System;
using System.Xml;

bool flag = true;
int value;

if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");