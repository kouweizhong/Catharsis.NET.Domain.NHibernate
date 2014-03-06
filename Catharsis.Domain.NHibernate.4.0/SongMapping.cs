using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Song"/> entity.</para>
  /// </summary>
  public sealed class SongMapping : SubclassMap<Song>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public SongMapping()
    {
      this.KeyColumn("Id");
      this.References(song => song.Album).Cascade.All().Column("AlbumId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatValue(typeof(SongsAlbum).Name, typeof(Song).Name)).Index("IX__{0}__AlbumId".FormatValue(typeof(Song).Name));
      this.Map(song => song.Audio).Length(1024).Not.Nullable();
    }
  }
}