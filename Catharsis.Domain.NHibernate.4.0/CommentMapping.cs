using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Comment"/> entity.</para>
  /// </summary>
  public sealed class CommentMapping : EntityMapping<Comment>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public CommentMapping()
    {
      this.CheckConstraint("DateCreated <= LastUpdated");
      this.Map(comment => comment.DateCreated).Index("IX__{0}__DateCreated".FormatValue(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.LastUpdated).Index("IX__{0}__LastUpdated".FormatValue(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.Name).Index("IX__{0}__Name".FormatValue(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.Text).Length(short.MaxValue).Not.Nullable();
    }
  }
}