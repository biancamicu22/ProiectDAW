using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;
namespace ProiectDAW.Controllers
{
    [Route("atractie")]
    [ApiController]
    public class AtractieController : ControllerBase
    {
        private IAtractieRepository _atractieRepository;
        private IMapper _autoMapper;
        public AtractieController(IAtractieRepository atractieRepository, IMapper autoMapper)
        {
            _atractieRepository = atractieRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] AtractieDTO atractie)
        {
            var atra = _autoMapper.Map<Atractie>(atractie);
            try
            {
                return Ok(_atractieRepository.Add(atra));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] AtractieUpdateDTO atractie)
        {
            var atra = _autoMapper.Map<Atractie>(atractie);
            try
            {
                return Ok(_atractieRepository.Edit(atra));
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
                return Ok(_atractieRepository.Delete(Id));
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
                return Ok(_atractieRepository.GetById(Id));
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
                return Ok(_atractieRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
