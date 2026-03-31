using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square(25, "red");
        Rectangle rec1 = new Rectangle(7, 10, "blue");
        Circle circle1 = new Circle(6.5, "green");

        List<Shape> shapesList = new List<Shape>();
        shapesList.Add(square1);
        shapesList.Add(rec1);
        shapesList.Add(circle1);

        foreach (Shape sh in shapesList)
        {
            double area = sh.GetArea();
            Console.WriteLine($"Area is {area}.");
        }

    }
}