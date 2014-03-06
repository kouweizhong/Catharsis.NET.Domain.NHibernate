using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="ProfileMapping"/>.</para>
  /// </summary>
  public sealed class ProfileMappingTests : EntityMappingTestsBase<Profile>
  {
    protected override void TestMappings(PersistenceSpecification<Profile> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Email, "email");
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckProperty(mapping => mapping.Photo, "photo");
      specification.CheckProperty(mapping => mapping.Type, "type");
      specification.CheckProperty(mapping => mapping.Url, "url");
      specification.CheckProperty(mapping => mapping.Username, "username");
    }
  }
}