﻿/*using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewAPI.Model;
using NewAPI.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IJWTSecurity _jwt;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IJWTSecurity jWTSecurity)
        {
            _logger = logger;
            _jwt = jWTSecurity;
        }


        [HttpGet]
        [Authorize(Policy ="DecaDevRole")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("get-token")]
        public IActionResult GetToken()
        {
            //embedding the user info to be carried along the JWT
            //creating a new user 
            var user = new User
            {
                //Id is autogenerated hence no assignment
                LastName = "Blesyn",
                FirstName = "Love",
                Email = "loveB@sample.com",
                Role = "Decadev"
            };
            var token = _jwt.JWTGen(user);
            return Ok(token);

        }
    }
}
*/