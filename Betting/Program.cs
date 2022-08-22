// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;
string[] command = {""} ;
while (command[0] != "exit")

{


Console.WriteLine("Please Submit Action");
 command = Console.ReadLine().Split(' ');

if (command.Length != 0 && command[0] == "deposit")
{
    Console.WriteLine($"{Environment.NewLine}your deposit of {command[1]} was successful");

}

if (command.Length != 0 && command[0] == "bet")
{
    Console.WriteLine($"{Environment.NewLine}your bet of {command[1]} was successful");

}

if (command.Length != 0 && command[0] == "withdraw")
{
    Console.WriteLine($"{Environment.NewLine}your withdraw of {command[1]} was successful");

}

if (command.Length != 0 && command[0] == "exit")
{
    Console.WriteLine($"{Environment.NewLine}Thank you for playing!Hope to see again soon.");

}
}