using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("rezervare")]
    [ApiController]
    public class RezervareController : ControllerBase
    {
        private IRezervareRepository _rezervareRepository;
        private IMapper _autoMapper;
        public RezervareController(IRezervareRepository rezervareRepository, IMapper autoMapper)
        {
            _rezervareRepository = rezervareRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] RezervareDTO rezervare)
        {
            var rez = _autoMapper.Map<Rezervare>(rezervare);
            try
            {
                return Ok(_rezervareRepository.Add(rez));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] RezervareUpdateDTO rezervare)
        {
            var rez = _autoMapper.Map<Rezervare>(rezervare);
            try
            {
                return Ok(_rezervareRepository.Edit(rez));
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
                return Ok(_rezervareRepository.Delete(Id));
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
                return Ok(_rezervareRepository.GetById(Id));
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
                return Ok(_rezervareRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
