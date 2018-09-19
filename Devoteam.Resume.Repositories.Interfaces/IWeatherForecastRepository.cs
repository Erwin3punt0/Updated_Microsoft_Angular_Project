using System.Collections.Generic;
using Devoteam.Resume.Repositories.Models;

namespace Devoteam.Resume.Repositories.Interfaces
{
    public interface IWeatherForecastRepository
    {
        IEnumerable<WeatherForecast> Get();
    }
}
