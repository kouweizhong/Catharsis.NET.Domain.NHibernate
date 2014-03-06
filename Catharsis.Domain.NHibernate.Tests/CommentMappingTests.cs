using System;
using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CommentMapping"/>.</para>
  /// </summary>
  public sealed class CommentMappingTests : EntityMappingTestsBase<Comment>
  {
    protected override void TestMappings(PersistenceSpecification<Comment> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.DateCreated, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.LastUpdated, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckProperty(mapping => mapping.Text, "text");
    }
  }
}