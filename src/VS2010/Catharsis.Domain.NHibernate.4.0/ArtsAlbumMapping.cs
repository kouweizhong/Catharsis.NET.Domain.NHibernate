using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="ArtsAlbum"/> entity.</para>
  /// </summary>
  public sealed class ArtsAlbumMapping : SubclassMap<ArtsAlbum>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public ArtsAlbumMapping()
    {
      this.KeyColumn("Id");
      this.Map(album => album.PublishedOn).Index("IX__{0}__PublishedOn".FormatSelf(typeof(ArtsAlbum).Name));
    }
  }
}