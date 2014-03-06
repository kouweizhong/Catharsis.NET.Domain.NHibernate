using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ArticlesCategoryMapping"/>.</para>
  /// </summary>
  public sealed class ArticlesCategoryMappingTests : CategoryMappingTestsBase<ArticlesCategory>
  {
    protected override void TestMappings(PersistenceSpecification<ArticlesCategory> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}