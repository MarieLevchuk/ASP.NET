using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication_IoC.Reader
{
    public class EBookReader
    {
        public IReader Reader { get; set; }
        public EBookReader (IReader reader)
        {
            Reader = reader;
        }
        public void OpenBook()
        {
            Reader.OpenBook();
        }
    }
}
