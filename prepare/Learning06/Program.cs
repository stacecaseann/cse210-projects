using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Shape[] shapes = [
            new Rectangle("blue", 5,4),
            new Circle("red", 3),
            new Square("green",3),
            new Triangle("purple",2,5)
        ];
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetName()} - {shape.GetColor()} - {shape.GetArea()}");
        }
        
    }
}