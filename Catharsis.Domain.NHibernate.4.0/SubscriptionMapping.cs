using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Subscription"/> entity.</para>
  /// </summary>
  public sealed class SubscriptionMapping : EntityMapping<Subscription>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public SubscriptionMapping()
    {
      this.CheckConstraint("DateCreated <= LastUpdated");
      this.Map(subscription => subscription.Active).Index("IX__{0}__Active".FormatSelf(typeof(Subscription).Name)).Not.Nullable();
      this.Map(subscription => subscription.DateCreated).Index("IX__{0}__DateCreated".FormatSelf(typeof(Subscription).Name)).Not.Nullable();
      this.Map(subscription => subscription.Email).Index("IX__{0}__Email".FormatSelf(typeof(Subscription).Name)).Not.Nullable().Unique();
      this.Map(subscription => subscription.ExpiredOn).Index("IX__{0}__ExpiredOn".FormatSelf(typeof(Subscription).Name));
      this.Map(subscription => subscription.LastUpdated).Index("IX__{0}__LastUpdated".FormatSelf(typeof(Subscription).Name)).Not.Nullable();
      this.Map(subscription => subscription.Token).Index("IX__{0}__Token".FormatSelf(typeof(Subscription).Name)).Not.Nullable().Unique();
    }
  }
}