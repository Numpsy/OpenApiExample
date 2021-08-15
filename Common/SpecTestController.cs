using System;
using Microsoft.AspNetCore.Mvc;

namespace OpenApiExample.Controllers
{
    // A simple DTO with a System.TimeSpan as a property
    public class TimeSpanHolder
    {
        public System.TimeSpan timeSpan { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class SpecTestController : ControllerBase
    {
        [HttpGet]
        public TimeSpanHolder GetTimeSpan()
        {
            return new TimeSpanHolder();
        }
    }
}
