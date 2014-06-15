using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="AnnouncementsCategoryMapping"/>.</para>
  /// </summary>
  public sealed class AnnouncementsCategoryMappingTests : CategoryMappingTestsBase<AnnouncementsCategory>
  {
    protected override void TestMappings(PersistenceSpecification<AnnouncementsCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}