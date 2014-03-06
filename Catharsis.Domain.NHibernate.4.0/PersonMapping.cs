using Catharsis.Commons;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Person"/> entity.</para>
  /// </summary>
  public sealed class PersonMapping : EntityMapping<Person>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public PersonMapping()
    {
      this.CheckConstraint("BirthYear <= DeathYear");
      this.Map(person => person.BirthDay).Check("BirthDay >= 1 AND BirthDay <= 31").Index("IX__{0}__BirthDay".FormatValue(typeof(Person).Name));
      this.Map(person => person.BirthMonth).Check("BirthMonth >= 1 AND BirthMonth <= 12").Index("IX__{0}__BirthMonth".FormatValue(typeof(Person).Name));
      this.Map(person => person.BirthYear).Check("BirthYear >= 0").Index("IX__{0}__BirthYear".FormatValue(typeof(Person).Name));
      this.Map(person => person.DeathDay).Check("DeathDay >= 1 AND DeathDay <= 31").Index("IX__{0}__DeathDay".FormatValue(typeof(Person).Name));
      this.Map(person => person.DeathMonth).Check("DeathMonth >= 1 AND DeathMonth <= 12").Index("IX__{0}__DeathMonth".FormatValue(typeof(Person).Name));
      this.Map(person => person.DeathYear).Check("DeathYear >= 0").Index("IX__{0}__DeathYear".FormatValue(typeof(Person).Name));
      this.Map(person => person.Description).Length(short.MaxValue);
      this.Map(person => person.Image).Length(1024);
      this.Map(person => person.NameFirst).Index("IX__{0}__NameFirst".FormatValue(typeof(Person).Name)).Not.Nullable();
      this.Map(person => person.NameLast).Index("IX__{0}__NameLast".FormatValue(typeof(Person).Name)).Not.Nullable();
      this.Map(person => person.NameMiddle).Index("IX__{0}__NameMiddle".FormatValue(typeof(Person).Name));
    }
  }
}