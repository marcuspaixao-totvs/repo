using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Parking.Application.Interface;
using Parking.Dto;

namespace Parking.Web.Controlles
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
      

        public IParkingAppService _parkingAppService { get; set; }

        public ParkingController(IParkingAppService parkingAppService)
        {
            _parkingAppService = parkingAppService;
        }

        [HttpPost]
        public IActionResult Create ([FromBody]ParkingDto parking)
        {
            if (_parkingAppService.Create(parking))
                return Ok();
            else
                return BadRequest();
        }



        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            return Ok(_parkingAppService.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_parkingAppService.GetById(id));
        }

        [HttpGet("getallwithdapper")]
        public IActionResult GetAllWithDapper()
        {
            return Ok(_parkingAppService.GetAll());
        }


    }
}