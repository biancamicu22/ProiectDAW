using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;
using ProiectDAW.Utilities;

namespace ProiectDAW.Controllers
{
    [Route("cazare")]
    [ApiController]
    public class CazareController : ControllerBase
    {
        private ICazareRepository _cazareRepository;
        private IMapper _autoMapper;
        public CazareController(ICazareRepository cazareRepository, IMapper autoMapper)
        {
            _cazareRepository = cazareRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CazareDTO cazare)
        {
            var caz = _autoMapper.Map<Cazare>(cazare);
            try
            {
                return Ok(_cazareRepository.Add(caz));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [Authorization(Role.Admin)]
        [HttpPut]
        public IActionResult Update([FromBody] CazareUpdateDTO cazare)
        {
            var caz = _autoMapper.Map<Cazare>(cazare);
            try
            {
                return Ok(_cazareRepository.Edit(caz));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [Authorization(Role.Admin)]
        [HttpDelete("Id")]
        public IActionResult Delete(Guid Id)
        {
            try
            {
                return Ok(_cazareRepository.Delete(Id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("Id")]
        public IActionResult GetById( Guid Id)
        {
            try
            {
                return Ok(_cazareRepository.GetById(Id));
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
                return Ok(_cazareRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("byPret")]
        public void GetAllGrouped()
        {
              _cazareRepository.getCazareGroupBy();
           
        }
    }
}
