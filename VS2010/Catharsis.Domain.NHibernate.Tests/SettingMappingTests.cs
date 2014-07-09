using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="SettingMapping"/>.</para>
  /// </summary>
  public sealed class SettingMappingTests : EntityMappingTestsBase<Setting>
  {
    protected override void TestMappings(PersistenceSpecification<Setting> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckProperty(mapping => mapping.Name, "name");
      specification.CheckProperty(mapping => mapping.Value, "value");
    }
  }
}