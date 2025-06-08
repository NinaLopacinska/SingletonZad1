using SingletonMOJ;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.Log("Pierwszy Log");

            Thread t1 = new Thread(() => Logger.Instance.Log("Log z wątku 1"));
            Thread t2 = new Thread(() => Logger.Instance.Log("Log z wątku 2"));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Logger.Instance.Log("Oststni log");
            Console.ReadKey();
            
        }

    }
}



