using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Playcast"/> entity.</para>
  /// </summary>
  public sealed class PlaycastMapping : SubclassMap<Playcast>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public PlaycastMapping()
    {
      this.KeyColumn("Id");
      this.Map(playcast => playcast.Audio).Length(1024);
      this.References(playcast => playcast.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatValue(typeof(Playcast).Name, typeof(PlaycastsCategory).Name)).Index("IX__{0}__CategoryId".FormatValue(typeof(Playcast).Name));
      this.Map(playcast => playcast.Image).Length(1024);
    }
  }
}