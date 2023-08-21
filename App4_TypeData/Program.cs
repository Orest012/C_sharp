using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

interface ISubject {
    void NameTeacher();
    int NumOnTheWeek();
    void NameSubj();

}

class IMath : ISubject
{
    public void NameTeacher() { 
        Console.WriteLine("Ms. Smit"); 
    }
    public int NumOnTheWeek() {
        return 5;
    }
    public void NameSubj() {
        Console.WriteLine("Math");
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        dynamic age = Console.ReadLine();
        dynamic name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(age);
        Console.WriteLine(name);

        var student = new
        {
            Age = age,
            Name = name

        };

        Console.WriteLine(student);

        DateTime now = new DateTime(2002, 3, 12, 3, 4, 44);


        Console.WriteLine(now);
        IMath math = new IMath();
            math.NameTeacher();
            math.NameSubj();
            Console.WriteLine(math.NumOnTheWeek());
        }
    }
