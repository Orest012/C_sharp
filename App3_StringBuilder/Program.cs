using System;
using System.Globalization;
using System.Text;

namespace App3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Text.StringBuilder str = new System.Text.StringBuilder();
            string s = Console.ReadLine();

            str.Append(s);
            Console.WriteLine(str.ToString());

            StringBuilder str_1 = new StringBuilder();
            for (int i = str.Length-1; i >= 0; i--)
            {
                str_1.Append(str[i]);
            }
            Console.WriteLine(str_1.ToString());

            for (int i = 0; i < str_1.Length; i++) {
                if (str_1[i] == 's') {
                    str_1.Replace('s', 'd');
                }

                if (str_1[i] == 'a')
                {
                    str_1.Remove(i, i+1);
                }
            }

            Console.WriteLine(str_1);
        }
            
    }
}
