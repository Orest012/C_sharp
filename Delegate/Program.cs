using System;
using System.Collections.Generic;
using System.Linq;


public delegate void Add_Dlg(int a, string s);
public class MyError : Exception
{
    public MyError(string msg) : base(msg) { }
}


public class Task {
    Dictionary<int, string> task;

    public event Action WriteTask;
    public Task() { 
        task = new Dictionary<int, string>();
    }

    public void AddTask(int num, string name)
    {
        if (!task.ContainsKey(num))
        {
            task[num] = name;
            WriteTask.Invoke();
        }
        else {
                throw new Exception("Завдання з введеним номером уже є");
        }
    }

    

    public void DeleteTask(int number)
    {
            List<int> keysToRemove = new List<int>();

            foreach (var kvp in task)
            {
                if (kvp.Key == number)
                {
                    keysToRemove.Add(kvp.Key);
                }
            }

            foreach (int key in keysToRemove)
            {
                task.Remove(key);
            }
        }

        public void CompleteTask(string str)
        {
            foreach (var kvp in task.ToList()) // Копіюємо словник до списку, щоб уникнути помилки під час зміни колекції.
            {
                if (kvp.Value == str)
                {
                    task[kvp.Key] += " - Complete";
                }
            }
        }
        public bool ContainsTask(int ss) { 
            return task.ContainsKey(ss);
        }

    public string ReturnTask(int a) {
        string ss = "";
        foreach (var num in task) {
            if (num.Key == a) {
                ss = num.Value;
            }
        }

        return "This task is: " + ss;
    }
        
        public void PrintTask() {
            foreach (KeyValuePair<int, string> num in task) { 
                Console.WriteLine($"{num.Key.ToString()} {num.Value.ToString()}");
                
            }
        }
}
    public class Program
    {
        public static void Main()
        {
        #region Delegate
        Task task = new Task();

        Add_Dlg dleg = task.AddTask;
        Predicate<int> predicate = task.ContainsTask;
        Func<int, string> deleg_func = task.ReturnTask;

        try
        {
            task.WriteTask += DoWriteTask;
            task.AddTask(1, "Enter data");
            task.AddTask(2, "Enter count goods");
            dleg(3, "Go to lunch");
            

            task.PrintTask();
        }
        catch (MyError ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine();
        task.CompleteTask("Enter data");
        task.DeleteTask(2);

        Console.WriteLine(predicate(2));
        Console.WriteLine(predicate(3));

        task.PrintTask();

        System.Text.StringBuilder string_build = new System.Text.StringBuilder();

        string_build.Append(deleg_func(1));
        Console.WriteLine(Convert.ToString(string_build));
        #endregion

        #region Events;
        Person per = new Person();

        per.GoToSleep += Sleep;
        per.DoWork += Work;

        per.TakeHour(DateTime.Parse("20.8.2022 11:11:03"));
        #endregion

        Console.ReadKey();

        }
    static void Sleep() { // Обробник події
        Console.WriteLine("Go to sleep");
    }
    static void Work(object obj, EventArgs e) {
        Console.WriteLine("Go to work");
    }

    static void DoWriteTask() {
        Console.WriteLine("Task is written !!!");
    }

    }

