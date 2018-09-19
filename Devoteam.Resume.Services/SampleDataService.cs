using System;
using System.Collections.Generic;
using Devoteam.Resume.DataMapping.Interfaces;
using Devoteam.Resume.Repositories.Interfaces;
using Devoteam.Resume.Services.Interfaces;

namespace Devoteam.Resume.Services
{
    public class SampleDataService : ISampleDataService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;
        private readonly IMappings _dtoMappings;

        public SampleDataService(
            IWeatherForecastRepository weatherForecastRepository,
            Func<string, IMappings> mappings)
        {
            _weatherForecastRepository = weatherForecastRepository;
            _dtoMappings = mappings("DtoMappings");
        }

        public IEnumerable<Dto.WeatherForecast> GetWeatherForecast()
        {
            var weatherForecast =  _weatherForecastRepository.Get();

            return weatherForecast == null ? 
                null : 
                _dtoMappings.Mapper.Map<IEnumerable<Dto.WeatherForecast>>(weatherForecast);
        }
    }
}
