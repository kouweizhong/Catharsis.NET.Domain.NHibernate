namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="BlogEntryMapping"/>.</para>
  /// </summary>
  public sealed class BlogEntryMappingTests /*: ItemMappingTestsBase<BlogEntry>*/
  {
    /*protected override void TestMappings(PersistenceSpecification<BlogEntry> specification)
    {
      Assertion.NotNull(specification);

      var blog = new Blog("blog.name");
      specification.TransactionalSave(blog);

      base.TestMappings(specification);
      specification.CheckReference(mapping => mapping.Blog, blog);
    }*/
  }
}