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
      this.CheckConstraint("CreatedAt <= UpdatedAt");
      this.Map(comment => comment.CreatedAt).Index("IX__{0}__CreatedAt".FormatSelf(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.UpdatedAt).Index("IX__{0}__UpdatedAt".FormatSelf(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.Name).Index("IX__{0}__Name".FormatSelf(typeof(Comment).Name)).Not.Nullable();
      this.Map(comment => comment.Text).Length(short.MaxValue).Not.Nullable();
    }
  }
}