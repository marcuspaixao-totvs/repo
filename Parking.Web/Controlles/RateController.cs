using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Domain;

namespace Parking.Web.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class RateController : ControllerBase
    {
      

        public IRateAppService _rateAppService { get; set; }

        public RateController(IRateAppService rateAppService)
        {
            _rateAppService = rateAppService;
        }

        [HttpPost]
        public IActionResult Create ([FromBody]Rate rate)
        {
            if (_rateAppService.Create(rate))
                return Ok();
            else
                return BadRequest();
        }

        [HttpPut]
        public IActionResult Update([FromBody]Rate rate)
        {
            if (_rateAppService.Update(rate))
                return Ok();
            else
                return BadRequest();
        }


        [HttpDelete]
        public IActionResult Delete([FromBody]Rate rate)
        {
            if (_rateAppService.Delete(rate))
                return Ok();
            else
                return BadRequest();
        }




    }
}