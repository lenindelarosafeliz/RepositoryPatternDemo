using Application.Interfaces.Repositories;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using WebApi.Controllers.Base;

namespace WebApi.Controllers
{
    public class IdentificationsController : BaseController
    {
        private readonly ILogger<IdentificationsController> _logger;
        private readonly IUnitOfWork _unitOfWork ;

        public IdentificationsController(ILogger<IdentificationsController> logger,
                                         IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        // GET: /Identifications
        [HttpGet]
        public IEnumerable<Identification> Get()
        {

            _unitOfWork.Identificactions.Add(new Identification()
            {
                IdentificationType = new IdentificationType()
                {
                    Description = "Pasaporte"
                },
                Person = new Person()
                {
                    FirstName = "Isaias",
                    LastName = "Crisóstomos",
                    BirthDate = System.DateTime.Now
                },
                Number = "00117006222"
            });
            _unitOfWork.Complete();

            return _unitOfWork.Identificactions.GetAll();
        }

        // GET: /Identifications/5
        [HttpGet("{id}")]
        public Identification Get(int id)
        {
            return _unitOfWork.Identificactions.GetById(id);
        }

        // POST: /Identifications
        [HttpPost]
        public void Post([FromBody]Identification identification)
        {
            _unitOfWork.Identificactions.Add(identification);
            _unitOfWork.Complete();
        }

        // PUT: /Identifications/5
        [HttpPut]
        public void Put(int id, [FromBody] Identification identification)
        {
            _unitOfWork.Identificactions.Update(id, identification);
            _unitOfWork.Complete();
        }

        // PUT: /Identifications/5
        [HttpDelete]
        public void Delete(int id, Identification identification)
        {
            _unitOfWork.Identificactions.Remove(identification);
            _unitOfWork.Complete();
        }
    }
}
