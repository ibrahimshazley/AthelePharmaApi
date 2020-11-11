using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AthelePharmaERP_API.Models;
using AthelePharmaERP_API.Models.Entities;
using AthelePharmaERP_API.Services.Abstraction;
using AutoMapper;
using AthelePharmaERP_API.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AthelePharmaERP_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionRequestController : ControllerBase
    {
        private readonly PharmaERPTestContext _context;
        private readonly IPemission_RequestService _service;
        private readonly IMapper _mapper;

        public PermissionRequestController(PharmaERPTestContext context, IPemission_RequestService service, IMapper mapper)
        {
            _context = context;
            _service = service;
            _mapper = mapper;
        }
        // GET: api/PermissionRequest
        [HttpGet]
        public IActionResult Get()
        {
           return Ok(_service.GetAllRequests());
        }

        // GET: api/PermissionRequest/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/PermissionRequest
        [HttpPost]
        public IActionResult AddPermissionRequest(PermissionRequestDTO request)
        {
            //var result = _service.AddPermissionRequest(request);
            //if (result)
            //{
            //    return true;
            //}
            //return false;
             return Ok(_service.AddPermissionRequest(request));
        }

  
        // PUT: api/PermissionRequest/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
