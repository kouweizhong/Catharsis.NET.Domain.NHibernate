using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="CityMapping"/>.</para>
  /// </summary>
  public sealed class CityMappingTests : EntityMappingTestsBase<City>
  {
    protected override void TestMappings(PersistenceSpecification<City> specification)
    {
      Assertion.NotNull(specification);

      var country =  new Country("country.name", "ru");
      specification.TransactionalSave(country);

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckReference(mapping => mapping.Country, country);
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckProperty(mapping => mapping.Region, "region");
    }
  }
}