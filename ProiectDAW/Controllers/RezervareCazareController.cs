using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("rezervareCazare")]
    [ApiController]
    public class RezervareCazareController : ControllerBase
    {
        private IRezervareCazareRepository _rezervareCazareRepository;
        private IMapper _autoMapper;
        public RezervareCazareController(IRezervareCazareRepository rezervareCazareRepository, IMapper autoMapper)
        {
            _rezervareCazareRepository = rezervareCazareRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] RezervareCazareDTO rezervareCazare)
        {
            var rezcaz = _autoMapper.Map<RezervareCazare>(rezervareCazare);
            Guid id = Guid.NewGuid();
            rezcaz.ID = id;
            try
            {
                return Ok(_rezervareCazareRepository.Add(rezcaz));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] RezervareCazareUpdateDTO rezervareCazare)
        {
            var rezcaz = _autoMapper.Map<RezervareCazare>(rezervareCazare);
            try
            {
                return Ok(_rezervareCazareRepository.Edit(rezcaz));
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
                return Ok(_rezervareCazareRepository.Delete(Id));
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
                return Ok(_rezervareCazareRepository.GetById(Id));
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
                return Ok(_rezervareCazareRepository.List());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
