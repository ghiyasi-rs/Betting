// See https://aka.ms/new-console-template for more information
using Domain.Entity;



string[] command = { "" };
Balance balance = new Balance();
Bet bet;



while (command[0] != "exit")
{

    Console.WriteLine("Please Submit Action");
    command = Console.ReadLine().Split(' ');

    if (command.Length > 0 && command[0].Length > 0 && int.Parse(command[1]) > 0)
    {
        switch (command[0])
        {
            case "deposit":
                {
                    balance.CurrentBalance += int.Parse(command[1]);
                    Console.WriteLine($"{Environment.NewLine} your deposit of {command[1]} was successful.current balance is {balance.CurrentBalance}");
                    break;
                }
            case "bet":
                {
                    bet = new Bet(int.Parse(command[1]));

                    if (bet.Award == 0)
                    {
                        balance.CurrentBalance += bet.Award - int.Parse(command[1]);
                        Console.WriteLine($"{Environment.NewLine}you lose! Your current balance is {Math.Round(balance.CurrentBalance, 2)}");

                    }
                    else
                    {
                        balance.CurrentBalance += bet.Award - int.Parse(command[1]);
                        Console.WriteLine($"{Environment.NewLine}you won {bet.Award}. Your current balance is {Math.Round(balance.CurrentBalance, 2)}");
                    }
                    break;
                }
            case "withdraw":
                {
                    balance.CurrentBalance -= int.Parse(command[1]);

                    Console.WriteLine($"{Environment.NewLine}your withdraw of {command[1]} was successful. Your current balance is {Math.Round(balance.CurrentBalance, 2)}");
                    break;
                }
            case "exit":
                {
                    Console.WriteLine($"{Environment.NewLine}Thank you for playing!Hope to see again soon.");
                    break;
                }
            default:
                {
                    Console.WriteLine($"{Environment.NewLine}Your command is not valid. Please enter valid command.");
                    break;
                }


        }
    }
    else
        Console.WriteLine($"{Environment.NewLine}Your command is not valid. Please enter valid command.");



}