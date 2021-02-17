﻿using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {          
            var singleton1 = FileWorkerSingleton.Instance;
            var singleton2 = FileWorkerSingleton.Instance;

            singleton1.WriteText("singleton 1");
            singleton2.WriteText("singleton 2");

            singleton1.Save();
            singleton2.Save();
        }
    }
}