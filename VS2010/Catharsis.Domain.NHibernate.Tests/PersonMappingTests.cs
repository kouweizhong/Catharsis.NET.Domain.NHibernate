using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PersonMapping"/>.</para>
  /// </summary>
  public sealed class PersonMappingTests : EntityMappingTestsBase<Person>
  {
    protected override void TestMappings(PersistenceSpecification<Person> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.BirthDay, (byte) 1);
      specification.CheckProperty(mapping => mapping.BirthMonth, (byte) 12);
      specification.CheckProperty(mapping => mapping.BirthYear, (short) 2000);
      specification.CheckProperty(mapping => mapping.DeathDay, (byte) 31);
      specification.CheckProperty(mapping => mapping.DeathMonth, (byte) 2);
      specification.CheckProperty(mapping => mapping.DeathYear, (short) 2100);
      specification.CheckProperty(mapping => mapping.Description, "description");
      specification.CheckProperty(mapping => mapping.Image, "image");
      specification.CheckProperty(mapping => mapping.NameFirst, "nameFirst");
      specification.CheckProperty(mapping => mapping.NameLast, "nameLast");
      specification.CheckProperty(mapping => mapping.NameMiddle, "nameMiddle");
    }
  }
}