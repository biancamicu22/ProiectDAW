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
    public class PortofelController : Controller
    {
        private IPortofelRepository _portofelRepository;
        private IMapper _autoMapper;
        public PortofelController(IPortofelRepository portofelRepository, IMapper autoMapper)
        {
            _portofelRepository = portofelRepository;
            _autoMapper = autoMapper;
        }

        [HttpPost]
        public IActionResult Create(PortofelDTO portofel)
        {
            var port = _autoMapper.Map<Portofel>(portofel);
            _portofelRepository.Add(port);
            return Ok();
        }

        
    }
}
