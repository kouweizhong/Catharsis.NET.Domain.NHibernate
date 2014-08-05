using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="BlogEntry"/> entity.</para>
  /// </summary>
  public sealed class BlogEntryMapping : SubclassMap<BlogEntry>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public BlogEntryMapping()
    {
      this.KeyColumn("Id");
      this.References(entry => entry.Blog).Cascade.All().Column("BlogId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(BlogEntry).Name, typeof(Blog).Name)).Index("IX__{0}__BlogId".FormatSelf(typeof(BlogEntry).Name)).Not.Nullable();
    }
  }
}