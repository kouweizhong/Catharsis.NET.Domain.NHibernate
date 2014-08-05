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

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckProperty(mapping => mapping.Description, "description");
      specification.CheckProperty(mapping => mapping.Language, "ru");
      specification.CheckProperty(mapping => mapping.Name, "name");
    }
  }
}