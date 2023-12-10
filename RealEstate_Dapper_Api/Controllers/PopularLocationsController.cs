﻿using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.PopulerLocationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationsController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;

        public PopularLocationsController(IPopularLocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> PopulerLocationList()  
        {
            var value= await _locationRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    }
}