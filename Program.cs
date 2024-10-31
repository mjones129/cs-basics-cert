using System;
using System.Xml;

int val1 = 5;
if (val1 > 0)
{
    int val2 = 6;
    val1 = val2 + val1;
}
Console.WriteLine(val1);