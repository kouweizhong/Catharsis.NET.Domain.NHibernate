**Catharsis.NET.Domain.NHibernate** is a .NET library which contains [Fluent NHibernate](http://www.fluentnhibernate.org) ORM mappings for common domain business entities (like _Article_, _Blog_, _Comment_, _Download_, _Faq_, etc.), which are part of the **[Catharsis.NET.Domain](https://github.com/prokhor-ozornin/Catharsis.NET.Domain)** project.

ORM mappings for the following types of domain entities are provided :

1. Announcement/Announcements Category
2. Art/Arts Album
3. Article/Articles Category
4. Audio/Audios Category
5. Blog/Blog Entry
6. City/Country/Location
7. Comment
8. Download/Downloads Category
9. FAQ
10. Notification
11. Person
12. Playcast/Playcasts Category
13. Profile
14. Setting
15. Song/Songs Album
16. Subscription
17. Text/Texts Category
18. Video/Videos Category
19. Web Link/Web Links Category

ORM mappings are declared using standard [Fluent NHibernate](http://www.fluentnhibernate.org) syntax, for example :

> this.Table("Cities");

> this.Cache.ReadWrite();

> this.Id(city => city.Id).GeneratedBy.Native();

> this.References(city => city.Country).Cascade.All().Column("CountryId").Fetch.Join().ForeignKey("FK_Cities_Countries").Index("Cities__CountryId").Not.Nullable();

> this.Map(city => city.Name).Index("Cities__Name").Not.Nullable();

> this.Map(city => city.Region).Index("Cities__Region");

They can be included in your project as described in official FluentNHibernate library documentation, like that :

> var sessionFactory = Fluently.Configure()

> .Database(SQLiteConfiguration.Standard.ConnectionString("Data Source=Catharsis.Domain.NHibernate.Tests.db;Version=3;New=True").ShowSql().FormatSql())

> .Mappings(mappings => mappings.FluentMappings.AddFromAssembly(Assembly.Load("Catharsis.Domain.NHibernate")))

> .Mappings(mappings => mappings.FluentMappings

> .Add<CityMapping>())

> .ExposeConfiguration(configuration => new SchemaExport(configuration).Create(false, true))

> .BuildSessionFactory();

**NuGet package** is also available at : [https://www.nuget.org/packages/Catharsis.Domain.NHibernate](https://www.nuget.org/packages/Catharsis.Domain.NHibernate)

***

**Support**

This project needs your support for further developments ! Please consider donating.

- _Yandex.Money_ : 41001577953208

- _WebMoney (WMR)_ : R399275865890

[![Image](https://www.paypalobjects.com/en_US/i/btn/btn_donateCC_LG.gif)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=APHM8MU9N76V8 "Donate")