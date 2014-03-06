using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="TextMapping"/>.</para>
  /// </summary>
  public sealed class TextMappingTests : ItemMappingTestsBase<Text>
  {
    protected override void TestMappings(PersistenceSpecification<Text> specification)
    {
      Assertion.NotNull(specification);

      var textsCategory = new TextsCategory("category.name");
      var person = new Person("person.nameFirst", "person.nameLast");
      var translation = new TextTranslation("ru", "translation.name", "translation.text");
      specification.TransactionalSave(textsCategory);
      specification.TransactionalSave(person);
      specification.TransactionalSave(translation);

      base.TestMappings(specification);
      specification.CheckReference(mapping => mapping.Category, textsCategory);
      specification.CheckReference(mapping => mapping.Person, person);
      specification.CheckBag(mapping => mapping.Translations, new[] { translation });
    }
  }
}