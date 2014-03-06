using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="AnnouncementMapping"/>.</para>
  /// </summary>
  public sealed class AnnouncementMappingTests : ItemMappingTestsBase<Announcement>
  {
    protected override void TestMappings(PersistenceSpecification<Announcement> specification)
    {
      Assertion.NotNull(specification);

      var category = new AnnouncementsCategory("category.name");
      specification.TransactionalSave(category);

      base.TestMappings(specification);
      specification.CheckReference(mapping => mapping.Category, category);
      specification.CheckProperty(mapping => mapping.Currency, "rub");
      specification.CheckProperty(mapping => mapping.Image, "image");
      specification.CheckProperty(mapping => mapping.Price, (decimal) 1);
    }
  }
}