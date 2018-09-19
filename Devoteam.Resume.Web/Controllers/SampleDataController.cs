using System;
using System.Collections.Generic;
using Devoteam.Resume.DataMapping.Interfaces;
using Devoteam.Resume.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Devoteam.Resume.Web.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private readonly ISampleDataService _sampleDataService;
        private readonly IMappings _modelMappings;

        public SampleDataController(
            ISampleDataService sampleDataService,
            Func<string, IMappings> mappings)
        {
            _sampleDataService = sampleDataService;
            _modelMappings = mappings("ModelMappings");
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Models.WeatherForecast>> WeatherForecasts()
        {
            var weatherForecast =  _sampleDataService.GetWeatherForecast();

            if (weatherForecast == null)
                return NotFound();

            return Ok(_modelMappings.Mapper.Map<IEnumerable<Models.WeatherForecast>>(weatherForecast));
        }
    }
}
