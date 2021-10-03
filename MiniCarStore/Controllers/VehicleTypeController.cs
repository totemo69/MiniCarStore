using Microsoft.AspNetCore.Mvc;
using MiniCarStore.API.ApiModels;
using MiniCarStore.ApplicationCore.Entities;
using MiniCarStore.ApplicationCore.Interfaces;
using MiniCarStore.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniCarStore.Controllers
{
    [Route("api/[controller]")]
    public class VehicleTypeController : BaseApiController
    {
        private readonly IAsyncRepository<VehicleType> _vechicleTypeRepository;

        public VehicleTypeController(IAsyncRepository<VehicleType> vechicleTypeRepository)
        {
            _vechicleTypeRepository = vechicleTypeRepository;
        }

        [HttpGet] 
        public async Task<ActionResult<IEnumerable<VehicleTypeDTO>>> Get()
        {
            var vehicleTypes = await _vechicleTypeRepository.ListAllAsync();
            return vehicleTypes.Select(type => {
                return new VehicleTypeDTO()
                {
                    Id = type.Id,
                    Type = type.Type
                };
            }).ToList();
        }

        // GET api/<VehicleTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleTypeDTO>> Get(int id)
        {
            var vehicleType = await _vechicleTypeRepository.GetByIdAsync(id);

            if (vehicleType == null) return NotFound();

            return new VehicleTypeDTO()
            {
                Id = vehicleType.Id,
                Type = vehicleType.Type
            }; 
        }
    }
}
