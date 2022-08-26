// See https://aka.ms/new-console-template for more information
using Domain.Entity;


string[] command = { "" };
Balance balance = new Balance();
Bet bet;




while (command[0] != "exit")

    if (command.Length > 0)
    {

        Console.WriteLine("Please Submit Action");
        command = Console.ReadLine().Split(' ');

        if (command.Length > 0)
        {
            switch (command[0])
            {
                case "deposit":
                    {
                        if (IsValidInput(command)) // check to enter value for deposit
                        {
                            balance.CurrentBalance += double.Parse(command[1]);
                            Console.WriteLine($"{Environment.NewLine} your deposit of {command[1]} was successful.current balance is {balance.CurrentBalance}");

                        }
                        break;
                    }
                case "bet":
                    {
                        if (IsValidInput(command))
                        {
                            if (!IsValidBalance(command[1]))
                            {
                                Console.WriteLine($"{Environment.NewLine}Your current balance is less than your bet.");
                                break;
                            }

                            bet = new Bet(double.Parse(command[1]));
                          

                            if (bet.Award == 0)
                            {
                                balance.CurrentBalance += bet.Award - double.Parse(command[1]);
                                Console.WriteLine($"{Environment.NewLine}you lose! Your current balance is {Math.Round(balance.CurrentBalance, 2)}");

                            }
                            else
                            {
                                balance.CurrentBalance += bet.Award - double.Parse(command[1]);
                                Console.WriteLine($"{Environment.NewLine}you won {bet.Award}. Your current balance is {Math.Round(balance.CurrentBalance, 2)}");
                            }
                        }
                        break;
                    }
                case "withdraw":
                    {
                        if (!IsValidBalance(command[1]))
                        {
                            Console.WriteLine($"{Environment.NewLine}Your current balance is less than your withdraw.");
                            break;
                        }
                           

                        if (IsValidInput(command))
                        {
                            balance.CurrentBalance -= double.Parse(command[1]);

                            Console.WriteLine($"{Environment.NewLine}your withdraw of {command[1]} was successful. Your current balance is {Math.Round(balance.CurrentBalance, 2)}");

                        }
                    
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

 bool IsValidInput(string[] input)
{
    if (input.Length > 1 && double.TryParse(input[1], out _) && double.Parse(input[1]) > 0)
        return true;
    else
        return false;
}

 bool IsValidBalance(string value)
{
    if (double.Parse(value) <= balance.CurrentBalance)
        return true;
    else
        return false;
}
