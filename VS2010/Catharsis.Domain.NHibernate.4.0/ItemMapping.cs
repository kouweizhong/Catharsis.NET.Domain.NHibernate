using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Item"/> entity.</para>
  /// </summary>
  public sealed class ItemMapping : EntityMapping<Item>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public ItemMapping()
    {
      this.CheckConstraint("DateCreated <= LastUpdated");
      this.HasMany(item => item.Comments).AsBag().Cascade.All().ForeignKeyConstraintName("FK__{0}__{1}".FormatSelf(typeof(Comment).Name, typeof(Item).Name)).KeyColumns.Add("ItemId", mapping => mapping.Index("IX__{0}__ItemId".FormatSelf(typeof(Comment).Name))).OrderBy("DateCreated");
      this.Map(item => item.DateCreated).Index("IX__{0}__DateCreated".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.Map(item => item.Language).Index("IX__{0}__Language".FormatSelf(typeof(Item).Name)).Length(3);
      this.Map(item => item.LastUpdated).Index("IX__{0}__LastUpdated".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.Map(item => item.Name).Index("IX__{0}__Name".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.HasMany(item => item.Tags).AsSet().Element("Tag", tag => tag.Not.Nullable()).ForeignKeyConstraintName("FK__ItemTag__Item").KeyColumns.Add("ItemId", mapping => mapping.Index("IX__ItemTag__ItemId")).OrderBy("Tag").Table("`ItemTag`");
      this.Map(item => item.Text).Length(short.MaxValue);
    }
  }
}