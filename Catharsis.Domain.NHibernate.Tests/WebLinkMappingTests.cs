using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="WebLinkMapping"/>.</para>
  /// </summary>
  public sealed class WebLinkMappingTests : ItemMappingTestsBase<WebLink>
  {
    protected override void TestMappings(PersistenceSpecification<WebLink> specification)
    {
      Assertion.NotNull(specification);

      var category = new WebLinksCategory("category.name");
      specification.TransactionalSave(category);

      base.TestMappings(specification);
      specification.CheckReference(mapping => mapping.Category, category);
      specification.CheckProperty(mapping => mapping.Url, "url");
    }
  }
}