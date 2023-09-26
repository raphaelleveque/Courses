using System;
namespace _145MetodosAbstratos.Entities {
    public class Rectangle : Shape {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}

