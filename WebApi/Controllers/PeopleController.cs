using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Interfaces.Repositories;
using Domain.Entities;
using WebApi.Controllers.Base;

namespace WebApi.Controllers
{
    public class PeopleController : BaseController
    {
        private readonly ILogger<PeopleController> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public PeopleController(ILogger<PeopleController> logger,
                                         IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        // GET: /Person
        [HttpGet]
        public IEnumerable<Person> Get()
        {
           return _unitOfWork.People.GetAll();
        }

        // GET: /Person/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return _unitOfWork.People.GetById(id);
        }

        // POST: /Identifications
        [HttpPost]
        public void Post([FromBody]Person person)
        {
            _unitOfWork.People.Add(person);
            _unitOfWork.Complete();
        }

        // PUT: /Person/5
        [HttpPut]
        public void Put(int id, [FromBody] Person person)
        {
            _unitOfWork.People.Update(id, person);
            _unitOfWork.Complete();
        }

        // DELETE: /Person/5
        [HttpDelete]
        public void Delete(int id, Person person)
        {
            _unitOfWork.People.Remove(person);
            _unitOfWork.Complete();
        }
    }
}
