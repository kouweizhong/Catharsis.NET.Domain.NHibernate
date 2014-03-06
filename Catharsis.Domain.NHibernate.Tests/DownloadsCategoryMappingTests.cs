using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="DownloadsCategoryMapping"/>.</para>
  /// </summary>
  public sealed class DownloadsCategoryMappingTests : CategoryMappingTestsBase<DownloadsCategory>
  {
    protected override void TestMappings(PersistenceSpecification<DownloadsCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}