using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Download"/> entity.</para>
  /// </summary>
  public sealed class DownloadMapping : SubclassMap<Download>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public DownloadMapping()
    {
      this.KeyColumn("Id");
      this.References(download => download.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Download).Name, typeof(DownloadsCategory).Name)).Index("IX__{0}__CategoryId".FormatSelf(typeof(Download).Name));
      this.Map(download => download.Downloads).Check("Downloads >= 0").Index("IX__{0}__Downloads".FormatSelf(typeof(Download).Name)).Not.Nullable();
      this.Map(download => download.Url).Length(1024).Not.Nullable();
    }
  }
}