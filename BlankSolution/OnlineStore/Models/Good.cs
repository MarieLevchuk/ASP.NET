using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Models
{
    public class Good
    {
        public int GoodId { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
