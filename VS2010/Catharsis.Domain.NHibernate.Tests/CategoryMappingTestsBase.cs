using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="ENTITY"></typeparam>
  public abstract class CategoryMappingTestsBase<ENTITY> : EntityMappingTestsBase<ENTITY> where ENTITY : Category
  {
    protected override void TestMappings(PersistenceSpecification<ENTITY> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(category => category.Description, "description");
      specification.CheckProperty(category => category.Language, "ru");
      specification.CheckProperty(category => category.Name, "name");
    }
  }
}