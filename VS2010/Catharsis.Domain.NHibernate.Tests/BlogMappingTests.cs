using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="BlogMapping"/>.</para>
  /// </summary>
  public sealed class BlogMappingTests : ItemMappingTestsBase<Blog>
  {
    protected override void TestMappings(PersistenceSpecification<Blog> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}