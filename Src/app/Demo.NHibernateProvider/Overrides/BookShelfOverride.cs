using Demo.Domain;
using NHibernate.Mapping.ByCode;

namespace Demo.NHibernateProvider.Overrides
{
  public class BookShelfOverride : IOverride
  {
    public void Override(ModelMapper mapper)
    {
      mapper.Class<BookShelf>(map =>
                                {
                                  map.Table("Book_Shelf");
                                  map.Id(x => x.Id,
                                         column =>
                                           {
                                             column.Column("BookID");
                                             column.Generator(Generators.GuidComb);
                                           });
                                }


        );
    }

  }
}