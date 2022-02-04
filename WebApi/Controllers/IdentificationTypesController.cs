using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Domain.Entities;
using WebApi.Controllers.Base;
using Application.Interfaces.Services;

namespace WebApi.Controllers
{
    public class IdentificationTypesController : BaseController
    {
        private readonly ILogger<IdentificationTypesController> _logger;
        private readonly IIdentificationTypeService _identificationTypeService;

        public IdentificationTypesController(ILogger<IdentificationTypesController> logger,
                                             IIdentificationTypeService identificationTypeService)
        {
            _logger = logger;
            _identificationTypeService = identificationTypeService;
        }
        
        // GET: /IdentificationTypes
        [HttpGet]
        public IEnumerable<IdentificationType> Get()
        {
           return _identificationTypeService.GetAll();
        }

        // GET: /IdentificationTypes/5
        [HttpGet("{id}")]
        public IdentificationType Get(int id)
        {
          return  _identificationTypeService.GetById(id);
        }

        // POST: /IdentificationTypes
        [HttpPost]
        public void Post([FromBody]IdentificationType identificationType)
        {
            _identificationTypeService.Add(identificationType);
        }

        // PUT: /IdentificationTypes/5
        [HttpPut]
        public void Put(int id, [FromBody] IdentificationType identificationType)
        {
            _identificationTypeService.Update(id, identificationType);
        }

        // DELETE: /IdentificationTypes/5
        [HttpDelete]
        public void Delete(int id, IdentificationType identificationType)
        {
            _identificationTypeService.Remove(id);
        }
    }
}
