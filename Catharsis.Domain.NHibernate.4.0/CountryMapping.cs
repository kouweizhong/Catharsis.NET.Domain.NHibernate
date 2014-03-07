using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Country"/> entity.</para>
  /// </summary>
  public sealed class CountryMapping : EntityMapping<Country>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public CountryMapping()
    {
      this.Cache.ReadWrite();
      this.Map(country => country.Image).Length(1024);
      this.Map(country => country.IsoCode).Index("IX__{0}__IsoCode".FormatSelf(typeof(Country).Name)).Length(2).Not.Nullable().Unique();
      this.Map(country => country.Name).Index("IX__{0}__Name".FormatSelf(typeof(Country).Name)).Not.Nullable().Unique();
    }
  }
}