using System;
namespace Exercicio01 {
    public class Worker {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        private Department department;
        private List<HourContract> Contracts = new List<HourContract>();

        public Worker() {
        }

        public Worker(string name, string level, double salary, Department dp) {
            Name = name;
            if (level == "junior") {
                Level = WorkerLevel.JUNIOR;
            } else if (level == "midlevel") {
                Level = WorkerLevel.MID_SENIOR;
            } else if (level == "senior") {
                Level = WorkerLevel.SENIOR;
            } else {
                Console.WriteLine("Wrong Worker Level");
            }
            BaseSalary = salary;
            department = dp;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);

        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double income = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Month == month && contract.Date.Year == year) {
                    income += contract.TotalValue();
                }
            }
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Department: {department.Name}");
            Console.WriteLine($"Income for {month}/{year}: {income}");
            return income;
        }
    }
}

