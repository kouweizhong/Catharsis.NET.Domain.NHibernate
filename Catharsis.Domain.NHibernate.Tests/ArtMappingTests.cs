using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ArtMapping"/>.</para>
  /// </summary>
  public sealed class ArtMappingTests : ItemMappingTestsBase<Art>
  {
    protected override void TestMappings(PersistenceSpecification<Art> specification)
    {
      Assertion.NotNull(specification);

      //var album = new ArtsAlbum("album.name");
      var person = new Person("person.nameFirst", "person.nameLast");

      //specification.TransactionalSave(album);
      specification.TransactionalSave(person);

      base.TestMappings(specification);
      //specification.CheckReference(mapping => mapping.Album, album);
      specification.CheckProperty(mapping => mapping.Image, "image");
      specification.CheckProperty(mapping => mapping.Material, "material");
      specification.CheckReference(mapping => mapping.Person, person);
      specification.CheckProperty(mapping => mapping.Place, "place");
    }
  }
}