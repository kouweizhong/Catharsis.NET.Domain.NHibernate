using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="WebLink"/> entity.</para>
  /// </summary>
  public sealed class WebLinkMapping : SubclassMap<WebLink>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public WebLinkMapping()
    {
      this.KeyColumn("Id");
      this.References(weblink => weblink.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(WebLink).Name, typeof(WebLinksCategory).Name)).Index("IX__{0}__CategoryId".FormatSelf(typeof(WebLink).Name));
      this.Map(weblink => weblink.Url).Length(1024).Not.Nullable();
    }
  }
}