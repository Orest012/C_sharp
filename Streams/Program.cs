using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();

            //Thread thread_1 = new Thread(new ParameterizedThreadStart(DoWork));
            //thread_1.Start(string.Empty);

            DoWorkAsync();

            Console.ReadKey();
        }
        #region Stream
        static void DoWork() {
            for (int i = 0; i < int.MaxValue / 1000; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine($"Hello world 1");
                }
            }
        }

        static void DoWork(object str)
        {
            for (int i = 0; i < int.MaxValue / 1000; i++)
            {
                if (i % 10000 == 0)
                {
                    Console.WriteLine($"Hello {(string)str} 2");
                }
            }
        }
        #endregion

        static async Task DoWorkAsync() 
        {
            await Task.Run(() => DoWork());
            Console.WriteLine("Do work Tas");
        }
    }
}
 