using System;
using System.Text;

class US { 
    private static int a;
    private int aa;

    public static int b;
    public static string c;    
    public int bb;


    public void set_private(int a, int aa) {
        US.a = a;
        this.aa = aa;
    }

    public void get_str() {
        Console.WriteLine(c);
    } 
    public void get_All() {
        Console.WriteLine($"a = {a}, aa = {aa}, b = {b}, b = {bb}");
    }

}
partial class User {
    public User(string name, int age, string email, int passowrd) {
        this.name = name;
        this.age = age;
        this.email = email;
        this.password = password;

    }

    public void Print() {
        Console.WriteLine($"name - {name}:\nage - {age},\nemail - {email}\npassowrd - {password}");
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        //Console.Write("Enter points: ");
        //int ekz;
        //int i = 0;
        //do
        //{
        //    ekz = int.Parse(Console.ReadLine());
        //    string str = ekz > 88 ? "Rating 5" :
        //                 (ekz >= 71 && ekz < 88) ? "Rating 4" :
        //                 (ekz < 71 && ekz >= 50) ? "Rating 3" :
        //                 (ekz < 50 && ekz >= 20) ? "Comition" :
        //                 (ekz >= 0 && ekz < 20) ? "Repeat Learning" : "Unknown";

        //    StringBuilder sb = new StringBuilder();
        //    sb.Append(str);

        //    Console.WriteLine(sb.ToString());
        //    i = int.Parse(Console.ReadLine());

        //} while (i != 1);
        ////////////////////////////////////////////////////////////////////
        //Banck obj = new Banck();
        //obj.set(1000);
        //Console.WriteLine(obj.get()); 
        ////////////////////////////////////////////////////////////////////
        //User obj = new User("Name", 18, "dadad", 123);
        //obj.Print();

        //US obj_1 = new US();
        //obj_1.bb = 100;
        //US.b = 10;

        //obj_1.set_private(20, 200);
        //obj_1.get_All();


        ////////////////////////////////////////////////////////////////////
        //int[] arr;
        //arr = new int[12];

        //for (int i = 0; i < 12; i++)
        //{
        //    arr[i] = i + 1;
        //}



        //foreach (int i in arr) {

        //    Console.Write($"{arr[i]} ");
        //}
        //Console.WriteLine();
        ////////////////////////////////////////////////////////////////////


        int[][] M_arr = new int[2][];
        M_arr[0] = new int[3] {1, 3, 5};
        M_arr[1] = new int[2] { 2, 4 };

        for (int i = 0; i < 2; i++) {
            if (i != 1)
            {
                for (int j = 0; j < 3; j++)
                {

                    Console.Write($"{M_arr[i][j]} ");
                }
            }
            else {
                for (int j = 0; j < 2; j++) {
                    Console.Write($"{M_arr[i][j]} ");
                }
            }
            Console.WriteLine();
        }

        int[][,] Double_arr = new int[2][,];

        Double_arr[0] = new int[2, 2] { { 1, 1 }, { 2, 2 } };
        Double_arr[1] = new int[2, 2] { { 3, 3 }, { 4, 4 } };

        Console.WriteLine();
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) {
                for (int k = 0; k < 2; k++) {
                    Console.Write($"{Double_arr[i][j, k]} ");
                }
                
            }
            Console.WriteLine();
        }

    }
}