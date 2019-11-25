using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ThreadTest
    {
        private string name;
        public ThreadTest(String name)
        {
            this.name = name;
        }

        public string Name { get=> name ; set => name = value; }

        public void ThreadRun()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(name + " - " + i);
            }
            
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                ThreadTest test = new ThreadTest("Thread " + i);
                Thread thread = new Thread(new ThreadStart(test.ThreadRun));
                thread.Start();
            }
            Console.ReadKey();

        }
    }
}
