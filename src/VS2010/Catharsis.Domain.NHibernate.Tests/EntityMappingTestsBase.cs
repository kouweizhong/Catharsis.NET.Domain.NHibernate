using System;
using System.Collections;
using System.Reflection;
using Catharsis.Commons;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Testing;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using Xunit;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="ENTITY"></typeparam>
  public abstract class EntityMappingTestsBase<ENTITY> where ENTITY : class, IEntity
  {
    private readonly ISessionFactory sessionFactory;

    /// <summary>
    ///   <para></para>
    /// </summary>
    protected EntityMappingTestsBase()
    {
      this.sessionFactory = Fluently.Configure()
        //.Database(SQLiteConfiguration.Standard.ConnectionString(connection => connection.FromConnectionStringWithKey("SQLite")).ShowSql().FormatSql())
        .Database(MsSqlConfiguration.MsSql2008.ConnectionString(connection => connection.FromConnectionStringWithKey("SQLServer")).ShowSql().FormatSql())
        //.Database(PostgreSQLConfiguration.Standard.ConnectionString(connection => connection.FromConnectionStringWithKey("PostgreSQL")).ShowSql().FormatSql())
        .Mappings(mappings => mappings.FluentMappings.AddFromAssembly(Assembly.Load("Catharsis.Domain.NHibernate")))
        .ExposeConfiguration(configuration =>
          {
            new SchemaExport(configuration).Drop(false, true);
            new SchemaExport(configuration).Create(false, true);
          }).BuildSessionFactory();
    }
    
    /// <summary>
    ///   <para></para>
    /// </summary>
    [Fact]
    public void Mappings()
    {
      using (var session = this.sessionFactory.OpenSession())
      {
        var specification = new PersistenceSpecification<ENTITY>(session, new EqualityComparer());
        this.TestMappings(specification);
        specification.VerifyTheMappings();
      }
    }

    /// <summary>
    ///   <para></para>
    /// </summary>
    /// <param name="specification"></param>
    /// <exception cref="ArgumentNullException">If <paramref name="specification"/> is a <c>null</c> reference.</exception>
    protected abstract void TestMappings(PersistenceSpecification<ENTITY> specification);

    private sealed class EqualityComparer : IEqualityComparer
    {
      public new bool Equals(object first, object second)
      {
        if (first is DateTime && second is DateTime)
        {
          return first.To<DateTime>().IsSameDate(second.To<DateTime>()) && first.To<DateTime>().IsSameTime(second.To<DateTime>());
        }

        return first.Equals(second);
      }

      public int GetHashCode(object subject)
      {
        return subject.GetHashCode();
      }
    }
  }
}