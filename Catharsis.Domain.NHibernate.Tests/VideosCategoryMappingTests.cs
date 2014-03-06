using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="VideosCategoryMapping"/>.</para>
  /// </summary>
  public sealed class VideosCategoryMappingTests : CategoryMappingTestsBase<VideosCategory>
  {
    protected override void TestMappings(PersistenceSpecification<VideosCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}