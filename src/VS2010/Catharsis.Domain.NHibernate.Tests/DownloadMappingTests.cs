using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="DownloadMapping"/>.</para>
  /// </summary>
  public sealed class DownloadMappingTests : ItemMappingTestsBase<Download>
  {
    protected override void TestMappings(PersistenceSpecification<Download> specification)
    {
      Assertion.NotNull(specification);

      var category = new DownloadsCategory("category.name");
      specification.TransactionalSave(category);

      base.TestMappings(specification);
      specification.CheckReference(mapping => mapping.Category, category);
      specification.CheckProperty(mapping => mapping.Downloads, (long) 1);
      specification.CheckProperty(mapping => mapping.Url, "url");
    }
  }
}