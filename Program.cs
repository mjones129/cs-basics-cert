using System;
using System.Runtime.ExceptionServices;
using System.Xml;

//foreach loop limitation

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
    Console.WriteLine(names[i]);
}