using System;
using System.Collections.Generic;
using Devoteam.Resume.Calculations;
using Devoteam.Resume.Calculations.Interfaces;
using Devoteam.Resume.DataMapping.Interfaces;
using Devoteam.Resume.Repositories;
using Devoteam.Resume.Repositories.Interfaces;
using Devoteam.Resume.Services;
using Devoteam.Resume.Services.Interfaces;
using Devoteam.Resume.Web.Mappings;
using Microsoft.Extensions.DependencyInjection;

namespace Devoteam.Resume.Web
{
    public static class DependencyContainer
    {
        public static void SetDependencies(IServiceCollection services)
        {
            services.AddTransient<ISampleDataService, SampleDataService>();
            services.AddTransient<ICelsiusToFahrenheit, CelsiusToFahrenheit>();
            services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

            services.AddTransient<ModelMappings>();
            services.AddTransient<DtoMappings>();

            services.AddTransient<Func<string, IMappings>>(serviceProvider => key =>
            {
                switch (key)
                {
                    case "ModelMappings":
                        return serviceProvider.GetService<ModelMappings>();
                    case "DtoMappings":
                        return serviceProvider.GetService<DtoMappings>();
                    default:
                        throw new KeyNotFoundException();
                }
            });
        }
    }
}
