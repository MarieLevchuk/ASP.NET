using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    class School : Education
    {
        public override void Enter()
        {
            Console.WriteLine("go to the first class");
        }

        public override void Study()
        {
            Console.WriteLine("attend school");
        }

        public override void GetDocument()
        {
            Console.WriteLine("get certificate of secondary education");
        }
    }
}
