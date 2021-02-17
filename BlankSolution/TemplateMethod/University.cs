using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class University : Education
    {
        public override void Enter()
        {
            Console.WriteLine("enroll in  university");
        }

        public override void GetDocument()
        {
            Console.WriteLine("The higher school certificate");
        }

        public override void Study()
        {
            Console.WriteLine("attend lectures");
        }

        public override void PassExams()
        {
            Console.WriteLine("state exams");
        }
    }
}
