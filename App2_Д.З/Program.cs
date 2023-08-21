using System;

class Person {
    private string Name;
    public string get()
    {
        return Name;
    }

    public void SetName(string v)
    {
        if (!string.IsNullOrEmpty(v) && v.Length >= 3)
        {
            Name = v;
        }
        else
        {
            Console.WriteLine("Некоректне значення імені!");
        }
    }
}
class Rectangle {
    private int width;
    private int height;

    public void myRectangle(int width, int height) {
        this.height = height;
        this.width = width;
    }

    public int CalculateArea() {
        return height + width;
    }

    public void Calculate()
    {
        int res = height * width;
        System.Console.Write("res = ");
        System.Console.Write(res);
        System.Console.WriteLine("\n");
    }
}
internal class Program
{
    static void Main() {
        Rectangle obj = new Rectangle();
        obj.myRectangle(10, 30);
        int res = obj.CalculateArea();

        Person obj2 = new Person();
        obj2.SetName("Name_1");
        string s = obj2.get();
        System.Console.WriteLine(res);
        obj.Calculate();
        System.Console.WriteLine(s);
    }
}

