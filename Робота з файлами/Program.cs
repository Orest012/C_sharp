using System;
using System.Collections;
using System.IO;
using System.Net;



namespace Робота_з_файлами
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //    string str = "String #1";
            //    str = String.Join(" ", str);

            //    //Console.WriteLine(str); 


            //    str = "    String      #1";
            //        Console.WriteLine(str.Trim());
            //    str = str.Trim();


            //    string ss = "1 2 3 4 5 6";
            //    for (int i = 0; i < ss.Length-5; i++) {
            //        if (i % 2 != 0) {
            //            ss =  ss.Substring(6);
            //        }
            //    }
            //    Console.Write($"{ss} ");

            //    Console.WriteLine();
            //    Console.WriteLine(str.ToUpper());
            using (FileStream stream = new FileStream("File.txt", FileMode.OpenOrCreate))
            {

                string text = "Text  ";
                byte[] b = System.Text.Encoding.Default.GetBytes(text); 
                stream.Write(b, 0, b.Length);
            }

            using (FileStream file = new FileStream("File.txt", FileMode.Open))
            {
                Console.WriteLine(file.Length);
                byte[] bb = new byte[file.Length];

                file.Read(bb, 0, bb.Length);
                string str = System.Text.Encoding.Default.GetString(bb);
                Console.WriteLine(str);
            }

        }
    }
}
