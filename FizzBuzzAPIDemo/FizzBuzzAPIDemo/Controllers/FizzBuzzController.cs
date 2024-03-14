using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FizzBuzzAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzProcessor _iFizzBuzzProcessor;
        public FizzBuzzController(IFizzBuzzProcessor iFizzBuzzProcessor)
        {
            _iFizzBuzzProcessor = iFizzBuzzProcessor;
        }

        [HttpPost]
        public IEnumerable<FizzBuzzResponse> Process(string[] values)
        {
            try
            {
                var response = _iFizzBuzzProcessor.ProcessData(values);
                return response;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
