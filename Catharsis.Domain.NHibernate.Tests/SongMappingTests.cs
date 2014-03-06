using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SongMapping"/>.</para>
  /// </summary>
  public sealed class SongMappingTests : ItemMappingTestsBase<Song>
  {
    protected override void TestMappings(PersistenceSpecification<Song> specification)
    {
      Assertion.NotNull(specification);

      //var album = new SongsAlbum("ru", "album.name");
      //specification.TransactionalSave(album);

      base.TestMappings(specification);
      //specification.CheckReference(mapping => mapping.Album, album);
      specification.CheckProperty(mapping => mapping.Audio, "audio");
    }
  }
}