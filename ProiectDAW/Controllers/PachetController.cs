using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("pachet")]
    [ApiController]
    public class PachetController : ControllerBase
    {
        private IPachetRepository _pachetRepository;
        private IMapper _autoMapper;
        public PachetController(IPachetRepository pachetRepository, IMapper autoMapper)
        {
            _pachetRepository = pachetRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] PachetDTO pachet)
        {
            var pac = _autoMapper.Map<Pachet>(pachet);
            try
            {
                return Ok(_pachetRepository.Add(pac));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] PachetUpdateDTO pachet)
        {
            var pac = _autoMapper.Map<Pachet>(pachet);
            try
            {
                return Ok(_pachetRepository.Edit(pac));
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
                return Ok(_pachetRepository.Delete(Id));
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
                return Ok(_pachetRepository.GetById(Id));
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
                return Ok(_pachetRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
