using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="NotificationMapping"/>.</para>
  /// </summary>
  public sealed class NotificatioMappingTests : EntityMappingTestsBase<Notification>
  {
    protected override void TestMappings(PersistenceSpecification<Notification> specification)
    {
      Assertion.NotNull(specification);

      specification.CheckProperty(mapping => mapping.Id, (long) 1);
      specification.CheckProperty(mapping => mapping.Version, (long) 1);
      specification.CheckProperty(mapping => mapping.Language, "ru");
      specification.CheckProperty(mapping => mapping.Text, "text");
      specification.CheckProperty(mapping => mapping.Type, 1);
    }
  }
}