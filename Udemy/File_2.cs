using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class A
{
    public void Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("Sum: " + sum);
    }
}

public interface Dowork {
    string Run();
}

public static class StringExtens
{
    public static string Print(this string str, int a)
    {
        if (a == 0)
        {
            return "";
        }
        else if (a < 0)
        {
            throw new Exception("Error");
        }
        else
        {
            var ss = str.Split(' ');
            int index = 0;

            StringBuilder word = new StringBuilder();

            foreach (var num in ss)
            {
                if (index < a)
                {
                    word.Append(num);
                    word.Append(' ');
                    index++;
                }
            }
            return Convert.ToString(word);

        }
    }
}

public class Book {
    public  string Title { get; set; }
    public  int Price { get; set; }
}

public class BookList
{
    public IEnumerable<Book> GetBooks()
    {
        return new List<Book>()
        {
            new Book() { Title = "Book_2", Price = 2 },
            new Book() { Title = "Book_22", Price = 3 },
            new Book() { Title = "Book_3", Price = 10 },
            new Book() { Title = "Book_4", Price = 11 },

        };
    }
}