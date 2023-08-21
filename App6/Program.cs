using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Library {
    private string[] name_book;

    public Library() {
        name_book = new string[100];
    } 
    public string this[int index]
    {
        get { 
            return name_book[index];
        }

        set
        {
            name_book[index] = value;
        }
    }
}

class Book {
    private string[] data_about_book;
    public Book() { 
        data_about_book = new string[100]; 
    }
    public string this[int index]
    {
        get {
            return data_about_book[index];
        }
        set {
            data_about_book[index] = value;
        }
    }
}
/////////////////////////////////////////////////////////////////////////////
class Basket<T> {
    private List<T> list;
    public Basket() {
        list = new List<T>();
    }

    public void AddItem(T str) {
        list.Add(str);
    }
    public void RemoveItem(T item) {
        if (list.Contains(item))
        {
            list.Remove(item);
        }
        else {
            Console.WriteLine("Basket don't have this element... ");
        }
    }

    public void GetItem() {
        foreach (T num in list) {
            Console.Write(num);
            Console.Write(" ");
        }
        Console.WriteLine(); 
    }
    

}
    
internal class Program
    {
    static void Main(string[] args)
    {
        //Console.Write("Enter number of books: ");
        //int number = int.Parse(Console.ReadLine());

        //Library obj = new Library();
        //for (int i = 0; i < number; i++)
        //{
        //    Console.Write($"Enter name of book #{i + 1}: ");
        //    string str = Console.ReadLine();
        //    obj[i] = str;
        //}

        //// Виводимо назви книг на екран
        //for (int i = 0; i < number; i++)
        //{
        //    Console.WriteLine(obj[i]);
        //}

        //string data;
        //StringBuilder ss = new StringBuilder();

        //Console.WriteLine($"Select the book: from 0 to {number}");
        //int ii = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Enter info about book: ");
        //Console.Write("Name author - ");

        //data = Console.ReadLine();
        //ss.Append(data);
        //ss.Append(" ");
        //Console.Write("Year realese - ");
        //data = Console.ReadLine(); 
        //ss.Append(data);

        //Book book = new Book();
        //book[0] = Convert.ToString(ss);
        //Console.WriteLine(book[0]);
        //////////////////////////////////////////////////////////////
        Console.Write("Enter counts of element: ");
        int C = int.Parse(Console.ReadLine());
        
        string s;
        Basket<string> obj_B = new Basket<string>();
        for (int i = 0; i < C; i++) {
            s = Console.ReadLine();
            obj_B.AddItem(s);
        }
        Console.Write("Delete element: ");
        s = Console.ReadLine();
        obj_B.RemoveItem(s);
        obj_B.GetItem();
        
        

    }
}
