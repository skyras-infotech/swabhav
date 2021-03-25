﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernetApp.Model;
using NHibernate.Tool.hbm2ddl;

namespace FluentNHibernetApp
{
    class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory {
            get {
                if (_sessionFactory == null) {
                    InitializeFactory();
                }
                return _sessionFactory;
            }
        }

        private static void InitializeFactory()
        {
            _sessionFactory = Fluently.Configure()
                                      .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=NHibernateDemo; User Id=sa; Password=root;").ShowSql())
                                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Customer>())
                                      .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                                      .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
