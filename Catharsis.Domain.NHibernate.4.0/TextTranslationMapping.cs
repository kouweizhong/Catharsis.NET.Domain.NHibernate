using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="TextTranslation"/> entity.</para>
  /// </summary>
  public sealed class TextTranslationMapping : EntityMapping<TextTranslation>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public TextTranslationMapping()
    {
      this.Map(translation => translation.Language).Index("IX__{0}__Language".FormatSelf(typeof(TextTranslation).Name)).Length(3).Not.Nullable();
      this.Map(translation => translation.Name).Index("IX__{0}__Name".FormatSelf(typeof(TextTranslation).Name)).Not.Nullable();
      this.Map(translation => translation.Text).Length(short.MaxValue).Not.Nullable();
      this.Map(translation => translation.Translator).Index("IX__{0}__Translator".FormatSelf(typeof(TextTranslation).Name));
    }
  }
}