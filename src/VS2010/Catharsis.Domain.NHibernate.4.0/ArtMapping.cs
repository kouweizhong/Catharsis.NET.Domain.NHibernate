using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Art"/> entity.</para>
  /// </summary>
  public sealed class ArtMapping : SubclassMap<Art>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public ArtMapping()
    {
      this.KeyColumn("Id");
      this.References(art => art.Album).Cascade.All().Column("AlbumId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Art).Name, typeof(ArtsAlbum).Name)).Index("IX__{0}__AlbumId".FormatSelf(typeof(Art).Name));
      this.Map(art => art.Image).Length(1024).Not.Nullable();
      this.Map(art => art.Material).Index("IX__{0}__Material".FormatSelf(typeof(Art).Name));
      this.References(art => art.Person).Column("PersonId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Art).Name, typeof(Person).Name)).Index("IX__{0}__PersonId".FormatSelf(typeof(Art).Name));
      this.Map(art => art.Place);
    }
  }
}