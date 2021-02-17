using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExams();
            GetDocument();
        }
        public abstract void Enter();
        public abstract void Study();
        public virtual void PassExams()
        {
            Console.WriteLine("final exam");
        }
        public abstract void GetDocument();
    }
}
