using System;
using System.Collections.Generic;

namespace bankOperations
{
    class Program
    {
        static List<Account> listAccounts = new List<Account>();
        static void Main(string[] args)
        {
            string userOption = getUserOption();

            while (userOption != "X")
            {
                switch (userOption)
                {
                    case "1":
                        ShowAccounts();
                        break;
                    case "2":
                        createAccount();
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
                userOption = getUserOption();
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

        private static void ShowAccounts()
        {
            Console.WriteLine("Show accounts: ");
            if (listAccounts.Count == 0)
            {
                Console.WriteLine("There are no accounts yet");
                return;
            }
            for (int i = 0; i < listAccounts.Count; i++)
            {
                Account account = listAccounts[i];
                Console.WriteLine("#{0} - {1}", i, account);
                Console.WriteLine();
            }
        }

        private static void createAccount()
        {
            Console.WriteLine("Create new account");

            Console.WriteLine("Type 1 for checking account or 2 for savings account");
            int newAccountType = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the client's name");
            string newName = Console.ReadLine();

            Console.WriteLine("Type the password");
            string newPassword = Console.ReadLine();

            Console.WriteLine("Type the inicial balance");
            double newBalance = double.Parse(Console.ReadLine());

            Console.WriteLine("Type the credit");
            double newCredit = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountType: (Type)newAccountType, 
                                                            name: newName,
                                                            password: newPassword,
                                                            balance: newBalance,
                                                            credit: newCredit);
            
            listAccounts.Add(newAccount);

            Console.WriteLine("Account created");
            Console.WriteLine();
        }   
    }
}
