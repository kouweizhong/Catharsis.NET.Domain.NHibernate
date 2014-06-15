using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="AnnouncementsCategory"/> entity.</para>
  /// </summary>
  public sealed class AnnouncementsCategoryMapping : SubclassMap<AnnouncementsCategory>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public AnnouncementsCategoryMapping()
    {
      this.References(category => category.Parent).Column("ParentId").Index("IX__{0}__ParentId".FormatSelf(typeof(Category).Name)).ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Category).Name, typeof(Category).Name));
    }
  }
}