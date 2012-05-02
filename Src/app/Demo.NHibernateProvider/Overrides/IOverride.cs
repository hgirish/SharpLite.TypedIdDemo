using NHibernate.Mapping.ByCode;

namespace Demo.NHibernateProvider.Overrides
{
    internal interface IOverride
    {
        void Override(ModelMapper mapper);
    }
}
