using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Audio"/> entity.</para>
  /// </summary>
  public sealed class AudioMapping : EntityMapping<Audio>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public AudioMapping()
    {
      this.Map(audio => audio.Bitrate).Not.Nullable().Check("Bitrate >= 0").Index("IX__{0}__Bitrate".FormatValue(typeof(Audio).Name));
      this.References(audio => audio.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatValue(typeof(Audio).Name, typeof(AudiosCategory).Name)).Index("IX__{0}__CategoryId".FormatValue(typeof(Audio).Name));
      this.Map(audio => audio.Duration).Not.Nullable().Check("Duration >= 0").Index("IX__{0}__Duration".FormatValue(typeof(Audio).Name));
      this.Map(audio => audio.File).Column("`File`").Length(1024).Not.Nullable();
    }
  }
}