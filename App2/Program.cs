using System;

public  class en {
    enum DAY { 
        Monday,
        Tusday,
        Wensday 
    }

    public void method() {
        int i = 0;
        DAY today;
        while (i != 3) {
            if (i == 0)
            {
                today = DAY.Monday;
                Console.WriteLine($"Today is {today}");
            }
            else if (i == 1)
            {
                today = DAY.Tusday;
                Console.WriteLine($"Today is {today}");
            }

            else if (i == 2) { 
                today = DAY.Wensday;
                Console.WriteLine($"Today is {today}");
            }

            

            else
            {
                i = 1;
            }
            i++;
        }

    }
}

public class MyClass {
    private int a;
    public int M { // Подія в структуріПодія в структурі
        get {
            return a;
        }
        set {
            a = value;
        }
    }
}


public class MainClass
{
    public static void Main()
    {
        DateTime data = new DateTime(2100, 12, 12);
        Console.WriteLine(data.ToString());

        DateTime NOW = DateTime.Now;
        DateTime today = DateTime.Today;


        Console.WriteLine("\tNOW = {0}", NOW);
        Console.WriteLine("\ttoday={0}", today);

        int[] arr = new int[32];
        int j = 0;

        for (int i = 0; i < 32; i++) {
            DateTime t = DateTime.Now;
            arr[i] = (int)t.Second;
            if (i == 16 && j!=1) {
                j = 1;
                i = 10;
            }
        }

        for (int i = 0; i < arr.Length; i++) { 
            Console.WriteLine(arr[i]);
        }

        MyClass  obj = new MyClass();
        obj.M = 21;
        Console.WriteLine(obj.M);

        en obj_2 = new en();
        obj_2.method();
        // Вставь код для активации M.O.V.E
    }
}
