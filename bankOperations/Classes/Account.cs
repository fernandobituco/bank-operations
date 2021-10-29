namespace bankOperations
{
    public class Account
    {
        
        private Type AccountType { get; set; }
        private string Nome { get; set; }
        private string Password { get; set; }
        private double Credit { get; set; }
        private double Balance { get; set; }
        public Account(Type accountType, string nome, string password, double credit, double balance)
        {
            this.AccountType = accountType;
            this.Nome = nome;
            this.Password = password;
            this.Credit = credit;
            this.Balance = balance;

        }
    }

}