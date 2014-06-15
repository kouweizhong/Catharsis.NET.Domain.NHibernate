using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="LocationMapping"/>.</para>
  /// </summary>
  public sealed class LocationMappingTests : EntityMappingTestsBase<Location>
  {
    protected override void TestMappings(PersistenceSpecification<Location> specification)
    {
      Assertion.NotNull(specification);

      var country = new Country("city.country.name", "ru");
      var city = new City("city.name", country);
      specification.TransactionalSave(country);
      specification.TransactionalSave(city);

      specification.CheckProperty(mapping => mapping.Address, "address");
      specification.CheckReference(mapping => mapping.City, city);
      specification.CheckProperty(mapping => mapping.Latitude, (decimal) 90);
      specification.CheckProperty(mapping => mapping.Longitude, (decimal) 180);
      specification.CheckProperty(mapping => mapping.PostalCode, "postalCode");
    }
  }
}