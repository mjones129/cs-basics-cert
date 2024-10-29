using System;
using System.Xml;

//must-use variables
string permission = "Admin|Manager";
int level = 19;

string output = "";

if (level > 55 && permission.Contains("Admin"))
{
    output = "Welcome, Super Admin user.";
}
else if (level >= 55 && permission.Contains("Admin"))
{
    output = "Welcome, Admin user.";
}
else if (level >= 20 && permission.Contains("Manager"))
{
    output = "Contact an Admin for access.";
}
else if (level < 20 && permission.Contains("Manager"))
{
    output = "You do not have sufficient priveleges.";
}
else
{
    output = "You do not have sufficient privileges.";
}

Console.WriteLine(output);