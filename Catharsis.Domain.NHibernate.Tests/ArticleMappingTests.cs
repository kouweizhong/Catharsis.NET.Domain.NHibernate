using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ArticleMapping"/>.</para>
  /// </summary>
  public sealed class ArticleMappingTests : ItemMappingTestsBase<Article>
  {
    protected override void TestMappings(PersistenceSpecification<Article> specification)
    {
      Assertion.NotNull(specification);

      var category = new ArticlesCategory("category.name");
      specification.TransactionalSave(category);

      base.TestMappings(specification);
      specification.CheckProperty(mapping => mapping.Annotation, "annotation");
      specification.CheckReference(mapping => mapping.Category, category);
      specification.CheckProperty(mapping => mapping.Image, "image");
    }
  }
}