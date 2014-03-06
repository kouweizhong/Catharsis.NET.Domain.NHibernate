using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ArtsAlbumMapping"/>.</para>
  /// </summary>
  public sealed class ArtsAlbumMappingTests : ItemMappingTestsBase<ArtsAlbum>
  {
    protected override void TestMappings(PersistenceSpecification<ArtsAlbum> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}