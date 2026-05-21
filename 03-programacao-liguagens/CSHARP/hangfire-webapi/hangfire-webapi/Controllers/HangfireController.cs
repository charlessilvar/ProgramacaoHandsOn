using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hangfire_webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HangfireController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Hangfire from web api");
        }
        [HttpPost]
        [Route("[Action]")]
        public IActionResult Welcome()
        {
            var JobId = BackgroundJob.Enqueue(() => SendWelcomeEmail("Welcome to out app"));
            return Ok($"Job Id: {JobId}. Welcome email sent to the user!");
        }

        [HttpGet]
        [Route("[Action]/{timeSeconds?}")]
        public IActionResult Discount(int timeSeconds = 30)
        {
            int timeSecond = timeSeconds;
            var JobId = BackgroundJob.Schedule(() => SendWelcomeEmail("Welcome to out app"), TimeSpan.FromSeconds(timeSecond));
            return Ok($"Job Id: {JobId}. Discount email will be sent in {timeSecond} seconds!");
        }

        [HttpGet]
        [Route("[Action]")]
        [Obsolete]
        public IActionResult DatabaseUpdate()
        {
            RecurringJob.AddOrUpdate(() => SendWelcomeEmail("Welcome to out app"), Cron.Minutely);
            return Ok("Database check job initiated");
        }

        [HttpGet]
        [Route("[Action]/{timeSeconds?}")]
        public IActionResult Confirm(int timeSeconds = 30)
        {
            int timeSecond = timeSeconds;
            var ParentJobId = BackgroundJob.Schedule(() => SendWelcomeEmail("Email you asked to be unsubscribed!"), TimeSpan.FromSeconds(timeSecond));
            BackgroundJob.ContinueJobWith(ParentJobId, () => SendWelcomeEmail("You were unsubscribed!"));
            return Ok("Confirmation Job created!");
        }
        public void SendWelcomeEmail(string text)
        {
            Console.WriteLine(text);
        }
    }
}
