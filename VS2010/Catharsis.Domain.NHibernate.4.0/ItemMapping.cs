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
      this.CheckConstraint("CreatedAt <= UpdatedAt");
      this.HasMany(item => item.Comments).AsBag().Cascade.All().ForeignKeyConstraintName("FK__{0}__{1}".FormatSelf(typeof(Comment).Name, typeof(Item).Name)).KeyColumns.Add("ItemId", mapping => mapping.Index("IX__{0}__ItemId".FormatSelf(typeof(Comment).Name))).OrderBy("CreatedAt");
      this.Map(item => item.CreatedAt).Index("IX__{0}__CreatedAt".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.Map(item => item.Language).Index("IX__{0}__Language".FormatSelf(typeof(Item).Name)).Length(3);
      this.Map(item => item.UpdatedAt).Index("IX__{0}__UpdatedAt".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.Map(item => item.Name).Index("IX__{0}__Name".FormatSelf(typeof(Item).Name)).Not.Nullable();
      this.HasMany(item => item.Tags).AsSet().Element("Tag", tag => tag.Not.Nullable()).ForeignKeyConstraintName("FK__ItemTag__Item").KeyColumns.Add("ItemId", mapping => mapping.Index("IX__ItemTag__ItemId")).OrderBy("Tag").Table("`ItemTag`");
      this.Map(item => item.Text).Length(short.MaxValue);
    }
  }
}