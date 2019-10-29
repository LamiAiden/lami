using Microsoft.AspNetCore.Mvc;
using lami.Models.Test;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lami.Controllers
{
    [Route("api/test")]
    public class TestController : lamiController
    {
        public TestController()
        {
            
        }

        [HttpGet]
        [Route("")]
        public async Task<List<TestModel>> GetAsync()
        {
            return new List<TestModel>
            {
                new TestModel {Name = "John", BirthDate = new DateTime(1942, 11, 18)},
                new TestModel {Name = "Adams", BirthDate = new DateTime(1997, 05, 24)}
            };
        }
    }
}
