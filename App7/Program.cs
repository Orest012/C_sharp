using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Text;
class Program
{

    void funcList()
    {
        System.Collections.Generic.List<string> list = new System.Collections.Generic.List<string>();

        int ii = 1;
        while (ii != 0)
        {
            Console.Write("Enter new element: ");
            string str = Console.ReadLine();

            Console.Write("Do you want to stop (Enter - 0): ");
            ii = int.Parse(Console.ReadLine());

            list.Add(str);
            Console.WriteLine();
        }

        Console.WriteLine($"You have {list.Count} element");
        foreach (string num in list)
        {
            Console.WriteLine(num);
        }
    }

    void funcDictionary() {
        System.Collections.Generic.Dictionary<string, string> dictionary = new System.Collections.Generic.Dictionary<string, string>();
        dictionary.Add("Britain", "London");
        dictionary.Add("USA", "Washington");
        dictionary.Add("Ukrain", "Kyiv");
        dictionary.Add("Poland", "Warshawa");

        Console.Write("Enter the enithing country: ");
        string str = Console.ReadLine();

        if (dictionary.ContainsKey(str))
        {
            Console.WriteLine($"{str} - {dictionary[str]}");
        }

        else {
            Console.WriteLine("Error");
        }

    }

    void funcSortedList() {
        System.Collections.Generic.SortedList<char, string> sorted_list = new System.Collections.Generic.SortedList<char, string>();

        int ii = 1;
        while (ii != 0)
        {
            Console.Write("Enter any word: ");
            string str = Console.ReadLine();

            //char[] c = new char[1];
            char c;
            c = str[0];
            sorted_list.Add(c, str);

            Console.Write("If you want to stop, enter 0: ");
            ii = int.Parse(Console.ReadLine());
        }

        foreach (var a in sorted_list)
        {
            Console.WriteLine($"{(a.Key)} - {a.Value}; ");
        }
    }

    void funcHachSet()
    {
        HashSet<string> hash_set = new HashSet<string>();
        int ii = 1;
        while (ii != 0)
        {
            Console.Write("Enter anything name book: ");
            string str = Console.ReadLine();

            if (hash_set.Contains(str))
            {
                Console.WriteLine("Error");
            }
            else
            {
                hash_set.Add(str);
            }

            Console.Write("If you want to stop, enter 0: ");
            ii = int.Parse(Console.ReadLine());

        }

        foreach (string ss in hash_set)
        {
            Console.WriteLine($"{ss}");
        }

    }

    void funcQueue() {
        string ss = "Andriy Oleg Max Artem Artur";
        string[] str;
        str = ss.Split(' ');

        System.Collections.Generic.Queue<string> queue = new System.Collections.Generic.Queue<string>();
        for (int i = 0; i < str.Length; i++)
        {
            queue.Enqueue(str[i]);
        }

        for (int i = 0; i < str.Length; i++) {
            Console.WriteLine(queue.Dequeue());
        }
    }

    void funcStack() {
        System.Collections.Generic.Stack<string> stack = new System.Collections.Generic.Stack<string>();
        string str = Console.ReadLine();

        string[] s = str.Split(' ');
        for (int i = 0; i < s.Length; i++)
        {
            stack.Push(s[i]);
        }

        foreach (string num in stack) {
            Console.Write($"{num} ");
        }
        (int, string, string) person = (1, "Bill", "Gates");
    }

    void funcValueTuple()
    {
        (string[] ss, int[] aa, double[] bb) value_turple;
        value_turple.ss = new string[200];
        value_turple.aa = new int[200];
        value_turple.bb = new double[200];

        
        for(int i=0; i<2; i++)
        {
            Console.Write("Enter name: ");
            string str = Console.ReadLine();

            Console.Write("Enter age: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter points: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine();

            value_turple.ss[i] = str;
            value_turple.aa[i] = a;
            value_turple.bb[i] = b;
        }

        for (int i = 0; i < 2; i++) {
            Console.WriteLine($"Name - {value_turple.ss[i]}, Age - {value_turple.aa[i]}, Pionts - {value_turple.bb[i]}");
        }
    }

    void funcTuple()
    {
        Tuple<int, int, int, int, int, int, int, Tuple<int>> a = new Tuple<int, int, int, int, int, int, int, Tuple<int>>(1, 2, 3, 4, 5, 6, 7, new Tuple<int>(8));
        Console.WriteLine(a.Item1);
        Console.WriteLine(a.Item2);
        Console.WriteLine(a.Item3);
        Console.WriteLine(a.Item4);
        Console.WriteLine(a.Item5);
        Console.WriteLine(a.Item6);
        Console.WriteLine(a.Item7);
        Console.WriteLine(a.Rest.Item1);

    }

    static void Main(string[] args)
    {
        Program obj = new Program();
        //obj.funcList();
        //obj.funcSortedList();
        //obj.funcHachSet();
        //obj.funcQueue();
        //obj.funcStack();
        //obj.funcValueTuple();
        obj.funcTuple();
    }
}
