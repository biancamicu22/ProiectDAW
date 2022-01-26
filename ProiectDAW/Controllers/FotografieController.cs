using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("fotografie")]
    [ApiController]
    public class FotografieController : ControllerBase
    {
        private IFotografieRepository _fotografieRepository;
        private IMapper _autoMapper;
        public FotografieController(IFotografieRepository fotografieRepository, IMapper autoMapper)
        {
            _fotografieRepository = fotografieRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] FotografieDTO fotografie)
        {
            var foc = _autoMapper.Map<Fotografie>(fotografie);
            try
            {
                return Ok(_fotografieRepository.Add(foc));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] FotografieUpdateDTO fotografie)
        {
            var foc = _autoMapper.Map<Fotografie>(fotografie);
            try
            {
                return Ok(_fotografieRepository.Edit(foc));
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
                return Ok(_fotografieRepository.Delete(Id));
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
                return Ok(_fotografieRepository.GetById(Id));
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
                return Ok(_fotografieRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
