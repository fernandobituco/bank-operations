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
                        CreateAccount();
                        break;
                    case "3":
                        Deposit();
                        break;
                    case "4":
                        //Withdraw();
                        break;
                    case "5":
                        //Transfer();
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
            Console.WriteLine("3 - Deposit");
            Console.WriteLine("4 - Withdraw");
            Console.WriteLine("5 - Transfer");
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

        private static void CreateAccount()
        {
            Console.WriteLine("Create new account");

            Console.WriteLine("Type 1 for natural person or 2 for legal person");
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

        private static void Deposit()
        {
            Console.WriteLine("Select the account you want to deposit on");
            int acc = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Type the value you wish to deposit");
            double depositValue = int.Parse(Console.ReadLine());
            
            listAccounts[acc].deposit(depositValue);
        }
    }
}
