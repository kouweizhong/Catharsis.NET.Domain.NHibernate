using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Category"/> entity.</para>
  /// </summary>
  public sealed class CategoryMapping : EntityMapping<Category>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public CategoryMapping()
    {
      this.DiscriminateSubClassesOnColumn("Type").Index("IX__{0}__Type".FormatValue(typeof(Category).Name));
      this.Cache.ReadWrite();
      this.Map(category => category.Description).Length(short.MaxValue);
      this.Map(category => category.Language).Index("IX__{0}__Language".FormatValue(typeof(Category).Name)).Length(3);
      this.Map(category => category.Name).Index("IX__{0}__Name".FormatValue(typeof(Category).Name)).Not.Nullable();
    }
  }
}