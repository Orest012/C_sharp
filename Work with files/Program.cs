using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work_with_files
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region File
            //StreamReader file = new StreamReader("Students.txt");

            //string text = file.ReadLine();
            //string[] str = text.Split(' ');

            //string ss = "1234567890";

            //string[] name = new string[57];
            //int[] point = new int[3];


            //int count = 0;
            //int count_str = 0;
            //for (int i = 0; i < str.Length; i++) {
            //    for (int j = 0; j < ss.Length; j++) {
            //        if (str[i].Contains(ss[j]))
            //        {
            //            point[count] = int.Parse(str[i]);
            //            count++;
            //        }
            //    }
            //    if (i % 2 == 0) {
            //        name[count_str] = str[i];
            //        count_str++;
            //    }
            //}

            //int max = point[0];
            //int min = point[0];

            //count = 0;
            //count_str = 0;
            //for (int i = 0; i < point.Length; i++) {
            //    if (max < point[i])
            //    { 
            //        max = point[i];
            //        count++;
            //    }
            //    if (min > point[i]) {
            //        min = point[i];
            //        count_str++;
            //    }
            //}
            //Console.WriteLine($"Max point is - {max}, {name[count]}");
            //Console.WriteLine($"Min point is - {min}, {name[count_str]}");
            #endregion
            using (StreamWriter writer = new StreamWriter("C:\\Users\\User\\Desktop\\Text.txt", true, Encoding.UTF8))
            {
                writer.Write("Привіт !!!\n");
            }
            using (StreamReader reader = new StreamReader("C:\\Users\\User\\Desktop\\Text.txt"))
            {
                StringBuilder str = new StringBuilder();
                str.Append(reader.ReadToEnd());
                Console.WriteLine(str.ToString());

                
            }

                Console.ReadLine();
        }
    }
}
