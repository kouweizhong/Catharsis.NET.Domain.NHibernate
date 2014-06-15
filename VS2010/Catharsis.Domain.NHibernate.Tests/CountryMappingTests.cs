using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CountryMapping"/>.</para>
  /// </summary>
  public sealed class CountryMappingTests : EntityMappingTestsBase<Country>
  {
    protected override void TestMappings(PersistenceSpecification<Country> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Image, "image");
      specification.CheckProperty(mapping => mapping.IsoCode, "ru");
      specification.CheckProperty(mapping => mapping.Name, "name");
    }
  }
}