using _142HerancaPolimorfismo.Entities;
using System.Globalization;

namespace _142HerancaPolimorfismo;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the number of products: ");
        int nProducts = int.Parse(Console.ReadLine());
        List<Product> productList = new List<Product>();

        for (int i = 1; i <= nProducts; i++) {
            Console.WriteLine($"Product #{i} data: ");
            Console.Write("Common, used or imported(c / u / i) ? ");
            char condition = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Preço: ");
            double price = double.Parse(Console.ReadLine());
            Product product;

            switch (condition) {
                case 'c':
                    product = new Product(name, price);
                    break;
                case 'u':
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    product = new UsedProduct(date, name, price);
                    break;
                case 'i':
                    Console.Write("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine());
                    product = new ImportedProduct(fee, name, price);
                    break;
                default:
                    Console.WriteLine("Wrong Input, try again! ");
                    i--;
                    continue;
            }
            productList.Add(product);
        }

        Console.WriteLine("Price Tags:");
        foreach (Product p in productList) {
            Console.WriteLine(p.PriceTag());
        }

    }
}

