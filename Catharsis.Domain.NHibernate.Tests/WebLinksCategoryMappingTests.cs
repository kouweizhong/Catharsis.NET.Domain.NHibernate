using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="WebLinksCategoryMapping"/>.</para>
  /// </summary>
  public sealed class WebLinksCategoryMappingTests : CategoryMappingTestsBase<WebLinksCategory>
  {
    protected override void TestMappings(PersistenceSpecification<WebLinksCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}