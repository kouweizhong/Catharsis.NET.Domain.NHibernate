using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="PlaycastMapping"/>.</para>
  /// </summary>
  public sealed class PlaycastMappingTests : ItemMappingTestsBase<Playcast>
  {
    protected override void TestMappings(PersistenceSpecification<Playcast> specification)
    {
      Assertion.NotNull(specification);

      var category = new PlaycastsCategory("category.name");
      specification.TransactionalSave(category);

      base.TestMappings(specification);
      specification.CheckProperty(mapping => mapping.Audio, "audio");
      specification.CheckReference(mapping => mapping.Category, category);
      specification.CheckProperty(mapping => mapping.Image, "image");
    }
  }
}