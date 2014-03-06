using Catharsis.Commons;
using FluentNHibernate.Mapping;

namespace Catharsis.Domain.NHibernate
{
  /// <summary>
  ///   <para>NHibernate ORM relational mapping for <see cref="Announcement"/> entity.</para>
  /// </summary>
  public sealed class AnnouncementMapping : SubclassMap<Announcement>
  {
    /// <summary>
    ///   <para>Creates and setup new mapping.</para>
    /// </summary>
    public AnnouncementMapping()
    {
      this.KeyColumn("Id");
      this.References(announcement => announcement.Category).Cascade.All().Column("CategoryId").Fetch.Join().ForeignKey("FK__{0}__{1}".FormatValue(typeof(Announcement).Name, typeof(AnnouncementsCategory).Name)).Index("IX__{0}__CategoryId".FormatValue(typeof(Announcement).Name));
      this.Map(announcement => announcement.Currency).Index("IX__{0}__Currency".FormatValue(typeof(Announcement).Name)).Length(3);
      this.Map(announcement => announcement.Image).Length(1024);
      this.Map(announcement => announcement.Price).Check("Price >= 0").Index("IX__{0}__Price".FormatValue(typeof(Announcement).Name)).Scale(2);
    }
  }
}