using System.Xml;

namespace Intro_threads
{
    internal class Program
    {
        static ThreadLocal<int> localInt = new ThreadLocal<int>(true);
        static void Main(string[] args)
        {
            //Körs synkront
            //CountDown();
            //CountUp();

            //Köra asynkront
            //Thread thread1 = new Thread(CountDown);
            //Thread thread2 = new Thread(CountUp);

            //thread1.Start();
            //thread2.Start();

            //Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Started....");
            //Task t1 = Task.Run(() =>
            //{
            //    Counter();
            //});
            //t1.Wait();
            //Console.WriteLine($"Main Thread : {Thread.CurrentThread.ManagedThreadId} Completed....");


            //Thread th1 = new Thread(() => Method1(5, ""))
            //{
            //    Name = "First thread"
            //};

            //Thread th2 = new Thread(Method2)
            //{
            //    Name = "Second thread"
            //};
            //th1.Start();
            //th2.Start();
            //{

            //Thread th1 = new Thread(Incrementer);
            //Thread th2 = new Thread(Incrementer);

            //th1.Start();
            //th2.Start();

            //th1.Join();
            //th2.Join();

            //Console.WriteLine("Done");
            //Console.WriteLine(localInt.Values.Sum());



            Thread th1 = new Thread(Function);
            th1.IsBackground = true;
            th1.Start();

            
        }

        //public static void CountDown()
        //{
        //    for (int i = 10; i >= 0; i--)
        //    {
        //        Console.WriteLine("Timer #1 : " + i + " seconds");
        //        Thread.Sleep(500); //Vänta 1000 milisekunder
        //    }
        //    Console.WriteLine("Timer #1 is completed");
        //}        public static void CountUp()
        //{
        //    for (int i = 0; i <= 10; i++)
        //    {
        //        Console.WriteLine("Timer #2 : " + i + " seconds");
        //        Thread.Sleep(500); //Vänta 1000 milisekunder
        //    }
        //    Console.WriteLine("Timer #2 is completed");
        //}

        //static void Counter()
        //{
        //    Console.WriteLine($"Child thread : {Thread.CurrentThread.ManagedThreadId} Started....");
        //    for (int i = 0; i <= 5; i++)
        //    {

        //        Thread.Sleep(3000);
        //        Console.WriteLine($"Count Value : {i}");

        //    }
        //    Console.WriteLine($"Child Thread : {Thread.CurrentThread.ManagedThreadId} Completed....");

        //}


        //static void Method1(int num, string name)
        //{
        //    Console.WriteLine($"Method 1 started Using {Thread.CurrentThread.Name}");

        //    for (int i = 0; i <= num; i++)
        //    {
        //        Console.WriteLine($"Method 1 : {i}");
        //        Thread.Sleep(2000);
        //    }
        //    Console.WriteLine("Method 1 ended");
        //}
        //static void Method2()
        //{
        //    Console.WriteLine($"Method 2 Started using {Thread.CurrentThread.Name}");

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.WriteLine($"Method 2 {i}");
        //        Thread.Sleep(1000);
        //    }
        //    Console.WriteLine("Method 2 ended");
        //}

        //static void Incrementer()
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        localInt.Value++;
        //    }

        //}


        static void Function()
        {
            Console.WriteLine("Function 1 has started....");

            // vänta här

            Console.ReadLine();
            Console.WriteLine("Function 1 has ended....");
        }

    }
}

