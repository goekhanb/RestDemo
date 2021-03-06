﻿using RestDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestDemo.Controllers
{
    public class WeatherController : ApiController
    {
        List<WeatherInfo> listInfo = new List<WeatherInfo>();
        
        // GET: api/Weather
        public IEnumerable<WeatherInfo> Get()
        {
            var weatherInfoList = new List<WeatherInfo>();
            for (int i = 0; i < 10; i++)
            {
                var weather = new WeatherInfo
                {
                    id = i,
                    Location = $"Location {i}",
                    Degree = i * 23 / 17,
                    DateTime = DateTime.Now.ToUniversalTime()

                };

                weatherInfoList.Add(weather);
            }

            return weatherInfoList;
        }

        // GET: api/Weather/5
        public WeatherInfo Get(int id)
        {
            return new WeatherInfo

            {
                Location = $"Location {id}",
                Degree = id * 23 / 17,
                DateTime = DateTime.Now.ToUniversalTime()

            };

        }
    }
}
