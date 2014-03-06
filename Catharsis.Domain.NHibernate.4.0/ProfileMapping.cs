using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Profile"/> entity.</para>
  /// </summary>
  public sealed class ProfileMapping : EntityMapping<Profile>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public ProfileMapping()
    {
      this.Map(profile => profile.Email).Index("IX__{0}__Email".FormatValue(typeof(Profile).Name)).Not.Nullable();
      this.Map(profile => profile.Name).Index("IX__{0}__Name".FormatValue(typeof(Profile).Name)).Not.Nullable();
      this.Map(profile => profile.Photo).Length(1024);
      this.Map(profile => profile.Type).Index("IX__{0}__Type".FormatValue(typeof(Profile).Name)).Not.Nullable();
      this.Map(profile => profile.Url).Length(1024).Not.Nullable().Unique();
      this.Map(profile => profile.Username).Index("IX__{0}__Username".FormatValue(typeof(Profile).Name)).Not.Nullable();
    }
  }
}