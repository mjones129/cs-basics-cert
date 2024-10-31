using System;
using System.Runtime.ExceptionServices;
using System.Xml;

//using a for loop to iterate through an array

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}