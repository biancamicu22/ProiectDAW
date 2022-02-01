using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;
using System.Collections.Generic;

namespace ProiectDAW.Controllers
{
    [Route("bilet")]
    [ApiController]
    public class BiletController : ControllerBase
    {
        private IBiletRepository _biletRepository;
        private IMapper _autoMapper;
        public BiletController(IBiletRepository biletRepository, IMapper autoMapper)
        {
            _biletRepository = biletRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] BiletDTO bilet)
        {
            var bil = _autoMapper.Map<Bilet>(bilet);
            bil.ID = Guid.NewGuid();
            try
            {
                return Ok(_biletRepository.Add(bil));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] BiletUpdateDTO bilet)
        {
            var bil = _autoMapper.Map<Bilet>(bilet);
            try
            {
                return Ok(_biletRepository.Edit(bil));
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
                return Ok(_biletRepository.Delete(Id));
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
                return Ok(_biletRepository.GetById(Id));
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
                return Ok(_biletRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("ticketsBetweenRangeDate")]
        public List<Bilet> getAllTicketsBetweenRangeDate()
        {
            return _biletRepository.getBileteConditioned();
        }

    }
}
