using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonMOJ
{
    public sealed class Logger
    {
        //private static Logger _instance = null;



        // Obiekt do synchronizacji (dla bezpieczeństwa wątkowego)
        //private static readonly object _lock = new object();

        // Lazy<T> automatycznie dba o thread-safety i leniwe tworzenie instancji
        private static readonly Lazy<Logger> _instance = new Lazy<Logger>(() => new Logger());

        private Logger()//nikt poza klasą Logger nie może tworzyć instancji 
        {
            Console.WriteLine("Logger został utworzony.");
        }

        public static Logger Instance
        {
            get
            {
                //if (_instance == null)
                //{
                //lock (_lock)
                //{
                //if (_instance ==null)
                // {
                //_instance = new Logger();
                // }
                //}
                //_instance = new Logger();

                return _instance.Value;// Tworzenie przy pierwszym użyciu

                //}
                //return _instance;
            }
        }
        
        public void Log(string message)
        {
            Console.WriteLine( $"[LOG]: {message}");
        }
        

    }
}
