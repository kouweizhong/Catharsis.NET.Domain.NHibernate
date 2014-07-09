using System;
using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SubscriptionMapping"/>.</para>
  /// </summary>
  public sealed class SubscriptionMappingTests : EntityMappingTestsBase<Subscription>
  {
    protected override void TestMappings(PersistenceSpecification<Subscription> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckProperty(mapping => mapping.Active, true);
      specification.CheckProperty(mapping => mapping.DateCreated, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.Email, "email");
      specification.CheckProperty(mapping => mapping.ExpiredOn, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.LastUpdated, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.Token, "token");
    }
  }
}