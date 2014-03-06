using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="PlaycastsCategory"/> entity.</para>
  /// </summary>
  public sealed class PlaycastsCategoryMapping : SubclassMap<PlaycastsCategory>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public PlaycastsCategoryMapping()
    {
      this.References(category => category.Parent).Column("ParentId").Index("IX__{0}__ParentId".FormatValue(typeof(Category).Name)).ForeignKey("FK__{0}__{1}".FormatValue(typeof(Category).Name, typeof(Category).Name));
    }
  }
}