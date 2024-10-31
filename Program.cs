using System;
using System.Runtime.ExceptionServices;
using System.Xml;

//using a for loop to iterate through an array (reversed order from the first example, but this order refelcts the natural order in the array as it's initiated)

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}