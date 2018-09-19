using System.Collections.Generic;
using Devoteam.Resume.Dto;

namespace Devoteam.Resume.Services.Interfaces
{
    public interface ISampleDataService
    {
        IEnumerable<WeatherForecast> GetWeatherForecast();
    }
}
