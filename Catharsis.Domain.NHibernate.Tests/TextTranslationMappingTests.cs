using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TextTranslationMapping"/>.</para>
  /// </summary>
  public sealed class TextTranslationMappingTests : EntityMappingTestsBase<TextTranslation>
  {
    protected override void TestMappings(PersistenceSpecification<TextTranslation> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Language, "ru");
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckProperty(mapping => mapping.Text, "text");
      specification.CheckProperty(mapping => mapping.Translator, "translator");
    }
  }
}