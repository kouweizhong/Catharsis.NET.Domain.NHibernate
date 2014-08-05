using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Faq"/> entity.</para>
  /// </summary>
  public sealed class FaqMapping : SubclassMap<Faq>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public FaqMapping()
    {
      this.KeyColumn("Id");
    }
  }
}