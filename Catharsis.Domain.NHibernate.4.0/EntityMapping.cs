using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para></para>
  /// </summary>
  /// <typeparam name="ENTITY"></typeparam>
  public abstract class EntityMapping<ENTITY> : ClassMap<ENTITY> where ENTITY : class, IEntity
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    protected EntityMapping()
    {
      this.Id(entity => entity.Id).GeneratedBy.Native();
      this.Version(entity => entity.Version).Check("Version >= 0").Index("IX__{0}__Version".FormatValue(typeof(ENTITY).Name));
    }
  }
}