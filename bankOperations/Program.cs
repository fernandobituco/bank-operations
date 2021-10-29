using System;

namespace bankOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = getUserOption();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        //ShowAccounts();
                        break;
                    case "2":
                        //createAccount();
                        break;
                    case "3":
                        //Transfer();
                        break;
                    case "4":
                        //Withdraw();
                        break;
                    case "5":
                        //Deposit();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            Console.WriteLine("Thank you for using our services");
            
        }

        private static string getUserOption ()
        {
            Console.WriteLine("Select the option you wish");
            Console.WriteLine("1 - Show accounts");
            Console.WriteLine("2 - Create new account");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Deposit");
            Console.WriteLine("C - clear screen");
            Console.WriteLine("X - Exit");
            Console.WriteLine();

            string userOption = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return userOption;

        }
    }
}
