using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Blog"/> entity.</para>
  /// </summary>
  public sealed class BlogMapping : SubclassMap<Blog>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public BlogMapping()
    {
      this.KeyColumn("Id");
    }
  }
}