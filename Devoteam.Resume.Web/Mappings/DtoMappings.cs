using AutoMapper;
using Devoteam.Resume.Calculations.Interfaces;

namespace Devoteam.Resume.Web.Mappings
{
    public class DtoMappings : DataMapping.Mappings
    {
        private readonly ICelsiusToFahrenheit _celsiusToFahrenheit;

        public DtoMappings(ICelsiusToFahrenheit celsiusToFahrenheit)
        {
            _celsiusToFahrenheit = celsiusToFahrenheit;
        }

        protected override void CreateMaps(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<Repositories.Models.WeatherForecast, Dto.WeatherForecast>()
                .ForMember(dest => dest.DateFormatted, opt => opt.MapFrom(src => src.DateFormatted))
                .ForMember(dest => dest.TemperatureC, opt => opt.MapFrom(src => src.TemperatureC))
                .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary))
                .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => _celsiusToFahrenheit.Calculate(src.TemperatureC)))
            ;
        }
    }
}
