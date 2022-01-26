using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("facilitate")]
    [ApiController]
    public class FacilitateController : ControllerBase
    {
        private IFacilitatiRepository _facilitatiRepository;
        private IMapper _autoMapper;
        public FacilitateController(IFacilitatiRepository facilitatiRepository, IMapper autoMapper)
        {
            _facilitatiRepository = facilitatiRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] FacilitateDTO facilitate)
        {
            var fac = _autoMapper.Map<Facilitate>(facilitate);
            try
            {
                return Ok(_facilitatiRepository.Add(fac));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] FacilitateUpdateDTO facilitate)
        {
            var fac = _autoMapper.Map<Facilitate>(facilitate);
            try
            {
                return Ok(_facilitatiRepository.Edit(fac));
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
                return Ok(_facilitatiRepository.Delete(Id));
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
                return Ok(_facilitatiRepository.GetById(Id));
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
                return Ok(_facilitatiRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
