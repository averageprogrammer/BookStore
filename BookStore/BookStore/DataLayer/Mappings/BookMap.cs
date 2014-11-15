using BookStore.DataLayer.Tables;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer.Mappings
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Id(x => x.BookId).GeneratedBy.HiLo("NHHilo", "NextHi", "1000", "TableName = 'BookStore'");
            Map(x => x.BookName);
            Map(x => x.Price);
        }
    }
}
