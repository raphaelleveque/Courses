using System;
namespace _145MetodosAbstratos.Entities {
    public class Circle : Shape {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double Area() {
            return 3.14 * Math.Pow(Radius, 2);
        }

    }
}
