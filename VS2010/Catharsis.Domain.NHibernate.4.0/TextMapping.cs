using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Text"/> entity.</para>
  /// </summary>
  public sealed class TextMapping : SubclassMap<Text>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public TextMapping()
    {
      this.KeyColumn("Id");
      this.References(text => text.Category).Cascade.All().Column("CategoryId").Index("IX__{0}__CategoryId".FormatSelf(typeof(Text).Name)).Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Text).Name, typeof(TextsCategory).Name));
      this.References(text => text.Person).Column("PersonId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Text).Name, typeof(Person).Name)).Index("IX__{0}__PersonId".FormatSelf(typeof(Text).Name)).Not.Nullable();
      this.HasMany(text => text.Translations).AsSet().Cascade.All().ForeignKeyConstraintName("FK__{0}__{1}".FormatSelf(typeof(TextTranslation).Name, typeof(Text).Name)).KeyColumns.Add("TextId", mapping => mapping.Index("IX__{0}__TextId".FormatSelf(typeof(TextTranslation).Name))).OrderBy("Name");
    }
  }
}