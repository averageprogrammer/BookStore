using BookStore.DataLayer.Tables;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataLayer.SessionFactorys
{
    public class BookSession
    {
        public static ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                            .ConnectionString(c => c
                            .Server("")
                            .Database("BookStore")
                            .Username("")
                            .Password("")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Book>())
                .BuildSessionFactory();
        }
    }
}
