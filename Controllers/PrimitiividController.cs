﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace web2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrimitiividController : ControllerBase
    {

        // GET: primitiivid/hello-world
        [HttpGet("hello-world")]
        public string HelloWorld()
        {
            return "Hello world at " + DateTime.Now;
        }

        // GET: primitiivid/hello-variable/mari
        [HttpGet("hello-variable/{nimi}")]
        public string HelloVariable(string nimi)
        {
            return "Hello " + nimi;
        }

        // GET: primitiivid/add/5/6
        [HttpGet("add/{nr1}/{nr2}")]
        public int AddNumbers(int nr1, int nr2)
        {
            return nr1 + nr2;
        }

        // GET: primitiivid/multiply/5/6
        [HttpGet("multiply/{nr1}/{nr2}")]
        public int Multiply(int nr1, int nr2)
        {
            return nr1 * nr2;
        }

        // GET: primitiivid/do-logs/5
        [HttpGet("do-logs/{arv}")]
        public void DoLogs(int arv)
        {
            for (int i = 0; i < arv; i++)
            {
                Console.WriteLine("See on logi nr " + i);
            }
        }
        // GET: primitiivid/ramdom/5/25
        [HttpGet("random/{min}/{max}")]
        public int RandNumber(int min, int max)
        {
            Random random= new Random();
            return random.Next(min, max);
        }
        // GET: primitiivid/sunnipaev
        [HttpGet("sunnipaev/{date}")]
        public int Sunnipaev(DateTime date)
        {
          DateTime dateTime= DateTime.Now.Date;
          if (dateTime.Month >= date.Month)
          {
                if(dateTime.Day >= date.Day)
                {
                    return dateTime.Year-date.Year;
                }
          }
            return dateTime.Year - date.Year - 1;
        }
    }
}
