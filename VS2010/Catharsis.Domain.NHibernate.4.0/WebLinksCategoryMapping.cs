using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="WebLinksCategory"/> entity.</para>
  /// </summary>
  public sealed class WebLinksCategoryMapping : SubclassMap<WebLinksCategory>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public WebLinksCategoryMapping()
    {
      this.References(category => category.Parent).Column("ParentId").Index("IX__{0}__ParentId".FormatSelf(typeof(Category).Name)).ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Category).Name, typeof(Category).Name));
    }
  }
}