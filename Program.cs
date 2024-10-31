using System;
using System.Xml;

int value1 = 5;

if (value1 > 0)
{
    int value2 = 6;
    value1 = value1 + value2;
}
Console.WriteLine($"First Value: {value1}");