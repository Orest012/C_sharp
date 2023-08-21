using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Асинхроність_та_Багатопоточність
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread stream_1 = new Thread(
                delegate()
                {
                    PrintNumbers();
                }
                );
            stream_1.Start();

            Thread stream_2 = new Thread(new ThreadStart(PrintString));
            stream_2.Start();

            Console.ReadLine();
        }

        static void PrintNumbers() {
            Random rand = new Random();

            for (int i = 0; i < 100; i++) {
                int res = rand.Next(1001);
                WriteToFile(res);
                Console.WriteLine(res);
            }
        }

        static void PrintString() {
            Random rand = new Random();
            char[] ch = new char[5];

            for (int i = 0; i < 100; i++) {
                for (int j = 0; j < 5; j++)
                {
                    ch[j] = (char)rand.Next('a', 'z' + 1);

                    Console.Write(ch[j]);
                }
                Console.WriteLine();

                
                
            }
        }

        static void WriteToFile(int num) {
            using (var write = new StreamWriter("C:\\Users\\User\\Desktop\\Text_1.txt", true , Encoding.UTF8)) 
            {
                write.WriteLine(num);
            }
        }
        static async Task WriteToFile_1(int num) {
            await Task.Run(() => WriteToFile(num));
            
        }
    }
}
