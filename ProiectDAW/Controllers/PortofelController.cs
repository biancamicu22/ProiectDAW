using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProiectDAW.DTO;
using ProiectDAW.Models;
using ProiectDAW.Repository;
using System;

namespace ProiectDAW.Controllers
{
    [Route("portofel")]
    [ApiController]
    public class PortofelController : ControllerBase
    {
        private IPortofelRepository _portofelRepository;
        private IMapper _autoMapper;
        public PortofelController(IPortofelRepository portofelRepository, IMapper autoMapper)
        {
            _portofelRepository = portofelRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create([FromBody] PortofelDTO portofel)
        {
            var port = _autoMapper.Map<Portofel>(portofel);
            try
            {
                return Ok(_portofelRepository.Add(port));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] PortofelUpdateDTO portofel)
        {
            var port = _autoMapper.Map<Portofel>(portofel);
            try
            {
                return Ok(_portofelRepository.Edit(port));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpDelete("Id")]
        public IActionResult Delete(Guid Id )
        {
            try
            {
                return Ok(_portofelRepository.Delete(Id));
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
                return Ok(_portofelRepository.GetById(Id));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
