using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="SongsAlbum"/> entity.</para>
  /// </summary>
  public sealed class SongsAlbumMapping : SubclassMap<SongsAlbum>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public SongsAlbumMapping()
    {
      this.KeyColumn("Id");
      this.Map(album => album.Image).Length(1024);
      this.Map(album => album.PublishedOn).Index("IX__{0}__PublishedOn".FormatSelf(typeof(SongsAlbum).Name));
    }
  }
}