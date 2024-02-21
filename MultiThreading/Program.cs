using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Main Thread Started");

            Console.WriteLine("Main Method Started......");
            SomeMethod();

            Console.WriteLine("Main Method End");

            Console.ReadKey();

            ////Creating Threads
            //Thread t1 = new Thread(Method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread t2 = new Thread(Method2)
            //{
            //    Name = "Thread2"
            //};
            //Thread t3 = new Thread(Method3)
            //{
            //    Name = "Thread3"
            //};

            ////Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start();

            //Console.WriteLine("Main Thread Ended");
            //Console.Read();
            //Console.Read();
        }

        static void Method1()
        {
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }

        static void Method2()
        {
            Thread.Sleep(10000);
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method2 :" + i);
            }
        }
        static void Method3()
        {
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method3 :" + i);
            }
        }


        //public async static void SomeMethod()
        //{
        //    Console.WriteLine("Some Method Started......");
        //    await Task.Delay(TimeSpan.FromSeconds(10));
        //    Console.WriteLine("\n");
        //    Console.WriteLine("Some Method End");
        //}

        public async static void SomeMethod()
        {
            Console.WriteLine("Some Method Started......");
            await Wait();
            Console.WriteLine("Some Method End");
        }
        private static async Task Wait()
        {
            await Task.Delay(TimeSpan.FromSeconds(10));
            Console.WriteLine("\n10 Seconds wait Completed\n");
        }


        //USerController

        //public async Task<User> GetUSer()
        //{
        //    var user = await _service.GetUser();
        //    return user;
        //}

    }
}
