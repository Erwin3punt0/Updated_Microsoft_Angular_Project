using Dto = Devoteam.Resume.Dto;
using AutoMapper;

namespace Devoteam.Resume.Web.Mappings
{
    public class ModelMappings : DataMapping.Mappings
    {
        protected override void CreateMaps(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Dto.WeatherForecast, Models.WeatherForecast>()
                .ForMember(dest => dest.DateFormatted, opt => opt.MapFrom(src => src.DateFormatted))
                .ForMember(dest => dest.TemperatureC, opt => opt.MapFrom(src => src.TemperatureC))
                .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary))
                .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => src.TemperatureF))
            ;
        }
    }
}
