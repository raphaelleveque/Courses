using _155Excecoes.Entities.Exceptions;

namespace _155Excecoes.Entities {
    public class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) {
            Balance += amount;
        }

        public void Withdraw(double amount) {
            if (amount > Balance) {
                throw new NotEnoughBalanceException("The amount to withdraw is grater than your balance! ");
            }
            if (amount > WithdrawLimit) {
                throw new AmountGraterThanLimitException("The amount to withdraw is grater than the Withdraw Limit");
            }
            Balance -= amount;
        }
    }
}

