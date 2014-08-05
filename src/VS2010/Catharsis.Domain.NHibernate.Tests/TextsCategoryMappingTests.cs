using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TextsCategoryMapping"/>.</para>
  /// </summary>
  public sealed class TextsCategoryMappingTests : CategoryMappingTestsBase<TextsCategory>
  {
    protected override void TestMappings(PersistenceSpecification<TextsCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}