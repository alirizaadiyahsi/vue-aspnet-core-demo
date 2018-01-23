using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VueCoreForum.Web.Areas.Admin.Controllers
{
    [Route("api/admin/[controller]")]
    public class ValuesController : Controller
    {
        private static string[] Summaries = new[]
        {
            "A Freezing", "A Bracing", "A Chilly", "A Cool", "A Mild", "A Warm", "A Balmy", "A Hot", "A Sweltering", "A Scorching"
        };

        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 35 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}