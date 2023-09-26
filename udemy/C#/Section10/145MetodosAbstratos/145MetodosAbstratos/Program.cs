using _145MetodosAbstratos.Entities;
namespace _145MetodosAbstratos;

class Program {
    static void Main(string[] args) {
        Console.Write("Enter the number of shapes: ");
        int nShapes = int.Parse(Console.ReadLine());
        List<Shape> shapes = new List<Shape>(nShapes);

        for (int i = 1; i <= nShapes; i++) {
            Console.WriteLine($"Shape #{i} data: ");

            Console.Write($"Rectangle or Circle (r / c) ? ");
            char shape = char.Parse(Console.ReadLine());

            switch (shape) {
                case 'r':
                    Console.Write("Width: ");
                    double w = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double h = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(w, h));
                    break;

                case 'c':
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(r));
                    break;

            }
        }

        Console.WriteLine("\nShape Areas: ");
        foreach (var item in shapes) {
            Console.WriteLine($"{item.Area():N2}");
        }

    }
}


