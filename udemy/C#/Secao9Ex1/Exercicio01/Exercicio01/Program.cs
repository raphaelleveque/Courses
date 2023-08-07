using System;
using System.Globalization;
using Exercicio01;

internal class Program {
    private static void Main(string[] args) {
        Console.Write("Enter department's name: ");
        string dp = Console.ReadLine();
        Console.WriteLine("Enter worker data: ");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Level: (Junior/MidLevel/Senior): ");
        string level = Console.ReadLine();
        Console.Write("Base Salary: ");
        double salary = double.Parse(Console.ReadLine());
        Console.Write("How many contracts to this name? ");
        int contracts = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Department department = new Department(dp);
        Worker worker = new Worker(name, level, salary, department);

        for (int i = 0; i < contracts; i++) {
            Console.WriteLine($"Enter #{i + 1} Contract Data: ");
            Console.Write("Date (DD/MM/YYY): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Value per Hour: ");
            double valuePerHour = double.Parse(Console.ReadLine());
            Console.Write("Duration (Hours): ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine();
            HourContract contract = new HourContract(date, valuePerHour, duration);
            worker.AddContract(contract);
        }

        Console.Write("Enter month and year to calculate income (MM/YYYY): ");
        string[] findDate = Console.ReadLine().Split('/');
        int month = int.Parse(findDate[0]);
        int year = int.Parse(findDate[1]);
        worker.Income(year, month);

    }
}