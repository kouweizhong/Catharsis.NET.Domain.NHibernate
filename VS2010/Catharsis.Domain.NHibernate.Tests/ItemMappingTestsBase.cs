using System;
using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ItemMapping"/>.</para>
  /// </summary>
  public abstract class ItemMappingTestsBase<ENTITY> : EntityMappingTestsBase<ENTITY> where ENTITY : Item
  {
    protected override void TestMappings(PersistenceSpecification<ENTITY> specification)
    {
      Assertion.NotNull(specification);

      var comment = new Comment("comment.name", "comment.text");
      specification.TransactionalSave(comment);

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckInverseBag(mapping => mapping.Comments, new[] { comment });
      specification.CheckProperty(mapping => mapping.CreatedAt, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.Language, "ru");
      specification.CheckProperty(mapping => mapping.UpdatedAt, DateTime.UtcNow);
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckInverseBag(mapping => mapping.Tags, new[] { "first", "second" });
      specification.CheckProperty(mapping => mapping.Text, "text");
    }
  }
}