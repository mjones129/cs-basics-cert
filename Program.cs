using System;

int coinflip = new Random().Next(0, 2);
string result = "";
if (coinflip == 0)
result = "heads";
else result = "tails";
Console.WriteLine(result);