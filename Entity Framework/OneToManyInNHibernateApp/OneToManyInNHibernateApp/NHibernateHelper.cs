using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OneToManyInNHibernateApp.Model;

namespace OneToManyInNHibernateApp
{
    class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {
                    InitializeFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeFactory()
        {
            _sessionFactory = Fluently.Configure()
                                      .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=EmpAddrNHibernate; User Id=sa; Password=root;").ShowSql())
                                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                                      .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                                      .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
