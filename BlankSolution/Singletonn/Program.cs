using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {          
            var singleton1 = LoggerSingleton.Instance;
            var singleton2 = LoggerSingleton.Instance;

            singleton1.WriteText("singleton 1");
            singleton2.WriteText("singleton 2");

            singleton1.Save();
            singleton2.Save();
        }
    }
}
