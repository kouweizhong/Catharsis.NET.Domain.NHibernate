using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PlaycastsCategoryMapping"/>.</para>
  /// </summary>
  public sealed class PlaycastsCategoryMappingTests : CategoryMappingTestsBase<PlaycastsCategory>
  {
    protected override void TestMappings(PersistenceSpecification<PlaycastsCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}