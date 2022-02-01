using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("vacanta")]
    [ApiController]
    public class VacantaController : ControllerBase
    {
        private IVacantaRepository _vacantaRepository;
        private IMapper _autoMapper;
        public VacantaController(IVacantaRepository vacantaRepository, IMapper autoMapper)
        {
            _vacantaRepository = vacantaRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] VacantaDTO vacanta)
        {
            var vac = _autoMapper.Map<Vacanta>(vacanta);
            try
            {
                return Ok(_vacantaRepository.Add(vac));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut("Id")]
        public IActionResult Update([FromBody] VacantaUpdateDTO vacanta, [FromRoute] Guid Id)
        {
            var vac = _autoMapper.Map<Vacanta>(vacanta);
            try
            {
                return Ok(_vacantaRepository.Edit(vac));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("Id")]
        public IActionResult Delete(Guid Id)
        {
            try
            {
                return Ok(_vacantaRepository.Delete(Id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("Id")]
        public IActionResult GetById(Guid Id)
        {
            try
            {
                return Ok(_vacantaRepository.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_vacantaRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("vacantaRezervare")]
        public string GetVacantaRezervare()
        {
          return  _vacantaRepository.VacanteRezervariCazare();
        }
    }
}
