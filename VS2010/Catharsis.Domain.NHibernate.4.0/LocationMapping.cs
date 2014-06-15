using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Location"/> entity.</para>
  /// </summary>
  public sealed class LocationMapping : EntityMapping<Location>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public LocationMapping()
    {
      this.Map(location => location.Address).Index("IX__{0}__Address".FormatSelf(typeof(Location).Name)).Not.Nullable();
      this.References(location => location.City).Cascade.Delete().Column("CityId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Location).Name, typeof(City).Name)).Index("IX__{0}__CityId".FormatSelf(typeof(Location).Name)).Not.Nullable();
      this.Map(location => location.Latitude).Index("IX__{0}__Latitude".FormatSelf(typeof(Location).Name)).Precision(19).Scale(15);
      this.Map(location => location.Longitude).Index("IX__{0}__Longitude".FormatSelf(typeof(Location).Name)).Precision(19).Scale(15);
      this.Map(location => location.PostalCode).Index("IX__{0}__PostalCode".FormatSelf(typeof(Location).Name));
    }
  }
}