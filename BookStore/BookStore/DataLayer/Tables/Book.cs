using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer.Tables
{
    public class Book
    {
        public virtual int BookId { get; set; }
        public virtual string BookName { get; set; }
        public virtual string Price { get; set; }

    }
}
