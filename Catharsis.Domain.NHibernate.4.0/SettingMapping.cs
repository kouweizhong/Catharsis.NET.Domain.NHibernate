using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Setting"/> entity.</para>
  /// </summary>
  public sealed class SettingMapping : EntityMapping<Setting>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public SettingMapping()
    {
      this.Cache.ReadWrite();
      this.Map(setting => setting.Name).Index("IX__{0}__Name".FormatSelf(typeof(Setting).Name)).Not.Nullable().Unique();
      this.Map(setting => setting.Value).Length(short.MaxValue);
    }
  }
}