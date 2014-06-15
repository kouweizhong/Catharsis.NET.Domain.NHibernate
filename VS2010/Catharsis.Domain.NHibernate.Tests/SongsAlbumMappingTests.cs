using System;
using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SongsAlbumMapping"/>.</para>
  /// </summary>
  public sealed class SongsAlbumMappingTests : ItemMappingTestsBase<SongsAlbum>
  {
    protected override void TestMappings(PersistenceSpecification<SongsAlbum> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
      specification.CheckProperty(mapping => mapping.Image, "image");
      specification.CheckProperty(mapping => mapping.PublishedOn, DateTime.UtcNow);
    }
  }
}