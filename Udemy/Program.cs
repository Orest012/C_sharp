using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

#region Task #1
//public class Stopwatch {
//    private DateTime stopwatch = new DateTime();

//    public int[] Start(DateTime now_1) {
//        int[] arr = new int[3];
//        arr[0] = now_1.Hour ;
//        arr[1] = now_1.Minute;
//        arr[2] = now_1.Second;

//        return arr;

//    }

//    public int[] Stop(int[] arr, DateTime now_2) {
//        int[] arr_stop = new int[3];

//        arr_stop[0] = now_2.Hour;
//        arr_stop[1] = now_2.Minute;
//        arr_stop[2] = now_2.Second;

//        int[] res = new int[3];
//        for (int i = 0; i < 3; i++){
//            res[i] = arr_stop[i] - arr[i];

//        }

//        return res;
//    }
//}
#endregion

#region Task#2
//public class Post {
//    private string name_post;
//    private DateTime time_to_create;
//    private int[] result;

//    public Post() {
//        time_to_create = new DateTime();
//        result = new int[2]; 
//    }
//    public Post(DateTime now) 
//    : this()
//    {

//        time_to_create = now;
//    }

//    public Post(string str, DateTime now)
//    : this(now)
//    {
//        name_post = str;
//    }

//    public void voting(bool b) {
//        if (b == true)
//        {
//            result[0]++;
//        }
//        else {
//            result[1]++;
//        }
//    }

//    public void print_info() { 
//        Console.WriteLine($"Name post: {name_post}\nTime published: {time_to_create}\n\tResult voting:\tGood - {result[0]}   Beg - {result[1]}");
//    }
//}
#endregion Task #2

#region Task #3
//public class Stack {
//    int[] stack = new int[4];
//    int count = 0;
//    public void Add(int num)
//    {
//        int[] arr = new int[count + 1]; // Створюємо новий масив з більшим розміром
//        for (int i = 0; i < count; i++) {
//            arr[i + 1] = stack[i];
//        }
//        arr[0] = num;
//        stack = arr;
//        count++;



//    }

//    public void Print() {
//        for (int i = 0; i < count; i++) {
//            Console.WriteLine(stack[i]);
//        }
//    }

//    public void Pop(int index) {
//        int[] arr = new int[stack.Length];

//        for (int i = 0; i < stack.Length - 1; i++) {

//            if (i != index) {
//                arr[i] = stack[i];
//            }
//            if (i == index || i>index)
//            {
//                arr[i] = stack[i+1];
//            }
//        }
//        for (int i = 0; i < arr.Length; i++)
//        {
//            stack[i] = arr[i];
//        }

//    }

//    public void Clear() {
//        for (int i = 0; i < stack.Length; i++) {
//            stack[i] = 0;
//        }
//        count = 0;
//    }
//}
#endregion

#region Task #4
//public class Read : Dowork {
//    public string Run() {
//        return "Open book";
//    }
//}

//public class Draw : Dowork {
//    public string Run() {
//        return "Create idea";
//    }
//}

//public class Programing {
//    public string Run() {
//        return "Open the compiler";
//    }
//}

//public class Engine{
//    public void Execute(object obj) {
//        switch (obj) {
//            case Read obj_1:
//                Console.WriteLine(obj_1.Run());
//                break;
//            case Draw obj_1:
//                Console.WriteLine(obj_1.Run());
//                break;
//            case Programing obj_1:
//                Console.WriteLine(obj_1.Run());
//                break;
//            default:
//                Console.WriteLine("Error");
//                break;
//        }
//    }
//}
#endregion

namespace Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task #1
            //DateTime sec = DateTime.Now;
            //Stopwatch stopwatch = new Stopwatch();
            //int[] arr = new int[3];
            //arr = stopwatch.Start(sec);


            //foreach (int num in arr) {
            //    Console.Write($"{num} ");
            //}

            //int[] res = new int[3];

            //int i = 0;
            //while (i != 1) {
            //    Console.Write("Enter 1 if you want to stop stopwatch : ");
            //    i = int.Parse(Console.ReadLine());

            //    if (i == 1) {
            //        sec = DateTime.Now;
            //        res = stopwatch.Stop(arr, sec);
            //    }
            //}




            //foreach (int num in res) {
            //    Console.Write($"{num} ");
            //}
            #endregion Task #1
            #region Task #2
            //int i = 0;


            //    Console.Write("Enter name: ");
            //    string str = Console.ReadLine();

            //    DateTime now = DateTime.Now;
            //    Post obj = new Post(str, now);

            //bool b = true;
            //while (i != 1)
            //{
            //    Console.WriteLine("If post good enter - 1\nIf post bag enter  - 2");
            //    int res = int.Parse(Console.ReadLine());


            //    if (res == 1)
            //    {
            //        b = true;
            //    }
            //    else
            //    {
            //        b = false;
            //    }
            //    obj.voting(b);

            //    Console.WriteLine("If you want to end enter - 1");
            //    i = int.Parse(Console.ReadLine());
            //}

            //    obj.print_info();
            #endregion Task #2
            #region Task #3
            //Stack obj = new Stack();
            //obj.Add(1);
            //obj.Add(2);
            //obj.Add(3);
            //obj.Add(4);

            //obj.Pop(0);
            //obj.Print();
            #endregion
            #region Task #4
            //Draw obj = new Draw();
            //Engine check = new Engine();

            //check.Execute(obj);
            #endregion
            #region Task #5 (Extensible Method)
            //string str = "To do something right now...";
            //var words = str.Print(3);
            //Console.WriteLine(words);
            #endregion
            #region LINQ
            //var book = new BookList().GetBooks();
            //var n = book.Where(b => b.Price < 10).OrderBy(name => name.Title);

            //foreach (var num in n) {
            //    Console.WriteLine(num.Title + " " + num.Price);
            //}

            //int number = book.Max(max => max.Price);
            //Console.WriteLine("max = {0}", number);

            //number = book.Min(min => min.Price);
            //Console.WriteLine("min = {0}", number);

            //Console.WriteLine();

            //var list = book.Skip(3).Take(4);
            //foreach (var num in list) {
            //    Console.WriteLine(num.Title + " " + num.Price);
            //}

            //var rr = book.Single(num => num.Price == 2);
            //Console.WriteLine(rr.Title + " " + rr.Price);
            #endregion

            #region (Sort data from file)
            //Action<string> sort = name_file =>
            //{
            //    using (var reader = new StreamReader(name_file))
            //    {
            //        var text = reader.ReadToEnd();
            //        int index = 0, index_str = 0;


            //        List<int> Price = new List<int>();
            //        List<string> Name = new List<string>();

            //        string[] str = text.Split(new char[] { ' ', '\n', '-' });


            //        for (int i = 0; i < str.Length; i++)
            //        {
            //            if (int.TryParse(str[i], out int res))
            //            {
            //                Price.Add(res);
            //            }
            //            else
            //            {
            //                Name.Add(str[i]);
            //            }
            //        }


            //        index = 0;
            //        var resul_sort = Name.OrderBy(t => t);
            //        foreach (var num in resul_sort)
            //        {
            //            if (num != "")
            //            {
            //                Name[index++] = num;
            //            }
            //        }


            //        index = 0;
            //        var resul_price = Price.OrderBy(t => t);
            //        foreach (var num in resul_price)
            //        {
            //            Price[index++] = num;
            //        }


            //        Dictionary<string, int> dict = new Dictionary<string, int>();
            //        for (int i = 0; i < Price.Count; i++)
            //        {
            //            dict.Add(Name[i], Price[i]);
            //        }

            //        reader.Close();


            //        using (var write = new StreamWriter(name_file))
            //        {
            //            foreach (var num in dict)
            //            {
            //                write.WriteLine($"{num.Key} - {num.Value}");
            //            }
            //            write.Close();
            //        }
            //    }

            //};
            //sort("C:\\Users\\User\\Desktop\\Text.txt");
            #endregion

            Console.ReadLine();
        }
    }
}

