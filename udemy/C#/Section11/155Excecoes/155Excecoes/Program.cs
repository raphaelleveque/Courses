using _155Excecoes.Entities;
namespace _155Excecoes;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter account data: ");
        Console.Write("Number: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Holder: ");
        string holder = Console.ReadLine();
        Console.Write("Initial Balance: ");
        double balance = double.Parse(Console.ReadLine());
        Console.Write("Withdraw Limit: ");
        double limit = double.Parse(Console.ReadLine());

        Account account = new Account(num, holder, balance, limit);

        string input;
        do {
            Console.Write("\nEnter amount to withdraw: ");
            input = Console.ReadLine();
            if (input != null) {
                double withdraw = double.Parse(input);
                account.Withdraw(withdraw);
                Console.WriteLine("New Balance: " + account.Balance);
            }

        } while (input != null && account.Balance > 0);

    }
}

