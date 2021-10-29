using System;

namespace bankOperations
{
    public class Account
    {
        
        private Type AccountType { get; set; }
        private string Name { get; set; }
        private string Password { get; set; }
        private double Credit { get; set; }
        private double Balance { get; set; }
        public Account(Type accountType, string name, string password, double credit, double balance)
        {
            this.AccountType = accountType;
            this.Name = name;
            this.Password = password;
            this.Credit = credit;
            this.Balance = balance;

        }

        public override string ToString()
        {
            string status = "";
            status += "Account type : " + this.AccountType + " | ";
            status += "Name :" + this.Name + " | ";
            status += "Balance: " + this.Balance + " | ";
            status += "Credit: " + this.Credit + " | ";

            return status;
        }

        public void deposit(double depositValue)
        {
            this.Balance += depositValue;
            Console.WriteLine("Current {0}'s balance: {1}", this.Name, this.Balance);
        }

        public Boolean withdraw (double withdrawValue)
        {
            if (this.Balance + this.Credit < withdrawValue)
            {
                Console.WriteLine("Insuficient funds");
                return false;
            }  
            this.Balance -= withdrawValue;
            Console.WriteLine("Current {0}'s balance: {1}", this.Name, this.Balance);
            return true;
        }

        public void transfer (double transferValue, Account recievingAccount)
        {
            if(this.withdraw(transferValue))
            {
                recievingAccount.deposit(transferValue);
            }
        }

        public Boolean checkPassword(string tryPassword)
        {
            if (tryPassword == this.Password)
                return true;
            else
                return false;
        }
    }

}