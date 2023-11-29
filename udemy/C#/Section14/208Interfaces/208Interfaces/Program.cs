using System.Globalization;
using _208Interfaces.Entities;
using _208Interfaces.Payments;

namespace _208Interfaces;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter contract data: ");
        Console.Write("Number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Date (dd/MM/yyyy): ");
        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        Console.Write("Contract Value: ");
        double contractValue = double.Parse(Console.ReadLine());
        Console.Write("Enter number of installments: ");
        int months = int.Parse(Console.ReadLine());

        Contract myContract = new Contract(number, date, contractValue);

        ContractService contractService = new ContractService(new PaypalService());
        contractService.ProcessContract(myContract, months);

        Console.WriteLine("Installments:");
        foreach (Installment installment in myContract.Installments) {
            Console.WriteLine(installment);
        }

    }
}

