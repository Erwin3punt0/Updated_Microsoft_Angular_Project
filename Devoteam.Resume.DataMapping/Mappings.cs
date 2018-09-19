using AutoMapper;
using Devoteam.Resume.DataMapping.Interfaces;

namespace Devoteam.Resume.DataMapping
{
    public abstract class Mappings : IMappings
    {
        protected Mappings()
        {
            var config = new MapperConfiguration(CreateMaps);
            Mapper = config.CreateMapper();
        }

        protected abstract void CreateMaps(IMapperConfigurationExpression cfg);

        public IMapper Mapper { get; }
    }
}
