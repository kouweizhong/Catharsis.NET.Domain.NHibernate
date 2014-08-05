using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Article"/> entity.</para>
  /// </summary>
  public sealed class ArticleMapping : SubclassMap<Article>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public ArticleMapping()
    {
      this.KeyColumn("Id");
      this.Map(article => article.Annotation).Length(short.MaxValue);
      this.References(article => article.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatSelf(typeof(Article).Name, typeof(ArticlesCategory).Name)).Index("IX__{0}__CategoryId".FormatSelf(typeof(Article).Name));
      this.Map(article => article.Image).Length(1024);
    }
  }
}