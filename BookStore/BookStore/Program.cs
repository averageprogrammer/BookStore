using BookStore.DataLayer.SessionFactorys;
using BookStore.DataLayer.Tables;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    class Program
    {
        public static void Main(string[] args)
        {
            var sessionFactory = BookSession.CreateSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                using (var transaction = session.BeginTransaction())
                {
                    for (var i = 1; i < 5000; i++)
                    {
                        Book book = new Book();
                        book.BookName = "Test" + i;
                        book.Price = "$" + i;
                        session.Save(book);
                    }
                    transaction.Commit();
                }
                stopwatch.Stop();
                var time = stopwatch.Elapsed;
                Console.WriteLine(time);
                Console.ReadLine();
            }
        }
    }
}
