using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniCarStore.API.ApiModels;
using MiniCarStore.ApplicationCore.Entities;
using MiniCarStore.ApplicationCore.Interfaces;
using MiniCarStore.Configuration;
using MiniCarStore.Infrastructure.Data;

namespace MiniCarStore.API.Controllers
{
    [Route("api/[controller]")]
    public class VehicleMakerController : BaseApiController
    {
        private readonly IAsyncRepository<VehicleMake> _vechicleMakeRepository;

        public VehicleMakerController(IAsyncRepository<VehicleMake> vechicleMakeRepository)
        {
            _vechicleMakeRepository = vechicleMakeRepository;
        }

        // GET: api/VehicleMaker
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VehicleMakerDTO>>> GetVehicleMake()
        {
            var entity = await _vechicleMakeRepository.ListAllAsync();

            return entity.Select(type => {
                return new VehicleMakerDTO()
                {
                    Id = type.Id,
                    Make = type.Make
                };
            }).ToList();
        }

        // GET: api/VehicleMaker/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VehicleMakerDTO>> GetVehicleMake(int id)
        {
            var entity = await _vechicleMakeRepository.GetByIdAsync(id);

            if (entity == null) return NotFound();

            return new VehicleMakerDTO()
            {
                Id = entity.Id,
                Make = entity.Make
            };

        }

        // PUT: api/VehicleMaker/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicleMake(int id, CreateVehicleMakerDTO vehicleMake)
        {
            var entity = await _vechicleMakeRepository.GetByIdAsync(id);

            if (entity == null) return NotFound();

            entity.UpdateDetails(vehicleMake.Make);

            await _vechicleMakeRepository.UpdateAsync(entity);

            return NoContent();
        }

        // POST: api/VehicleMaker
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VehicleMakerDTO>> PostVehicleMake(CreateVehicleMakerDTO vehicleMake)
        {
            var newMaker = new VehicleMake(vehicleMake.Make);

            var createdItem = await _vechicleMakeRepository.AddAsync(newMaker);

            return new VehicleMakerDTO()
            {
                Id = createdItem.Id,
                Make = createdItem.Make
            };
        }

        // DELETE: api/VehicleMaker/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteVehicleMake(int id)
        //{
        //    var vehicleMake = await _context.VehicleMake.FindAsync(id);
        //    if (vehicleMake == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.VehicleMake.Remove(vehicleMake);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool VehicleMakeExists(int id)
        //{
        //    return _context.VehicleMake.Any(e => e.Id == id);
        //}
    }
}
