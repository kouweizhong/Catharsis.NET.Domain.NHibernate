using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Notification"/> entity.</para>
  /// </summary>
  public sealed class NotificationMapping : EntityMapping<Notification>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public NotificationMapping()
    {
      this.Cache.ReadWrite();
      this.Map(notification => notification.Language).Index("IX__{0}__Language".FormatValue(typeof(Notification).Name)).Length(3);
      this.Map(notification => notification.Text).Length(short.MaxValue).Not.Nullable();
      this.Map(notification => notification.Type).Index("IX__{0}__Type".FormatValue(typeof(Notification).Name)).Not.Nullable();
    }
  }
}