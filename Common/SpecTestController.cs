using System;
using Microsoft.AspNetCore.Mvc;

namespace OpenApiExample.Controllers
{
    // An integer type enum, and a function that returns it
    public enum Thing
    {
        Thing1 = 0,
        Thing2 = 1,
        Thing3 = 2
    }

    // A flags enum
    [Flags]
    public enum FlagsEnum
    {
        FirstFlag = 1,
        SecondFlag = 2,
        ThirdFlag = 4
    }

    public class PostRequest
    {
        public FlagsEnum RequestFlags { get; set; }
        public Thing? SomeThing { get; set; }
    }

    // base class / sub class
    public class ResponseBase
    {
        public int Id { get; set; }
    }

    public class ResponseDerived : ResponseBase
    {
        // public TimeSpan time { get; set; }
        public int time { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class SpecTestController : ControllerBase
    {
        [HttpGet]
        public Thing GetThing()
        {
            return Thing.Thing2;
        }

        [HttpGet("flags")]
        public string GiveItAFlag(FlagsEnum flags)
        {
            return flags.ToString();
        }

        [HttpPost]
        public void PostFlags(PostRequest request)
        {

        }

        [HttpGet("ResponseWithId")]
        public ResponseDerived GetResponse(int id)
        {
            return new ResponseDerived { Id = id, time = 5 };
        }
    }
}
