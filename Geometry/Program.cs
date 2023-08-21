using System;


public class Circle<T> : IGeometricShape<T> where T : struct 
{
    private T radius;

    public Circle(T radius)
    {
        if (Convert.ToInt32(radius) < 0)
        {
            throw new MyException("Radius under zero");
        }
        else
        {
            this.radius = radius;
        }
    }

    public double Area()
    {
        double res = Convert.ToDouble(radius);
        return Math.PI * res * res;
    }

    public double Perimeter()
    {
        double res = Convert.ToDouble(radius);
        return 2 * Math.PI * res;
    }
}

public class Rectangle<T> : IGeometricShape<T> where T : struct
{
    private T Width;
    private T Hight;

    public Rectangle(T width, T hight)
    {
        if (Convert.ToInt32(width) < 0 || Convert.ToInt32(hight) < 0)
        {
            throw new MyException("Error");
        }
        else
        {
            Width = width;
            Hight = hight;
        }
    }   

    public double Area() {
        double width = Convert.ToDouble(Width);
        double hight = Convert.ToDouble(Hight);

        return width * hight;
    }
    public double Perimeter() {
        double width = Convert.ToDouble(Width);
        double hight = Convert.ToDouble(Hight);

        return 2*(width * hight);
    }
}

public class GeometricCalculator<T> where T : class
{
    public double Area(T obj)
    {
        if (obj is Circle<double> circle)
        {
            return circle.Area();
        }
        else if (obj is Rectangle<double> rectange) {
            return rectange.Area();
        }
        // Якщо obj не є екземпляром класу Circle або є null, повертаємо значення за замовчуванням.
        return 0.0;
    }

    public double Perimeter<T>(T obj) where T : class
    {
        if (obj is Circle<double> circle)
        {
            return circle.Perimeter();
        }
        else if (obj is Rectangle<double> rectange)
        {
            return rectange.Perimeter();
        }
        // Якщо obj не є екземпляром класу Circle або є null, повертаємо значення за замовчуванням.
        return 0.0;
    }
}

namespace Geometry
{
    internal class Program
    {
        void Error(string msg) { 
    
}
        static void Main(string[] args)
        {
            try
            {
                Circle<double> obj = new Circle<double>(2.3);
                Console.WriteLine(obj.Area());
            }
            catch (MyException ex) {
                Console.WriteLine("Error");
                Console.WriteLine(ex.Message);
            }
            Circle<double> res = new Circle<double>(1.2);

            GeometricCalculator<Circle<double>> obj_1 = new GeometricCalculator<Circle<double>>();
            
            Console.WriteLine(obj_1.Area(res));
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
