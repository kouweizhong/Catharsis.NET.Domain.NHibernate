using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="AudiosCategoryMapping"/>.</para>
  /// </summary>
  public sealed class AudiosCategoryMappingTests : CategoryMappingTestsBase<AudiosCategory>
  {
    protected override void TestMappings(PersistenceSpecification<AudiosCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}