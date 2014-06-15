using Catharsis.Commons;
using FluentNHibernate.Testing;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>Tests set for class <see cref="FaqMapping"/>.</para>
  /// </summary>
  public sealed class FaqMappingTest : ItemMappingTestsBase<Faq>
  {
    protected override void TestMappings(PersistenceSpecification<Faq> specification)
    {
      Assertion.NotNull(specification);

      base.TestMappings(specification);
    }
  }
}