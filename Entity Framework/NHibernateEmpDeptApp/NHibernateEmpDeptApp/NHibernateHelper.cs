﻿using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernateEmpDeptApp.Model;

namespace NHibernateEmpDeptApp
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
                                      .Database(MsSqlConfiguration.MsSql2012.ConnectionString("server=.\\SQLExpress; Database=NHibernateEmpDept; User Id=sa; Password=root;"))
                                      .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Dept>())
                                      .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, false))
                                      .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
