using Application.Interfaces.Repositories;
using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Infrastructure
{
    public class IdentificationTypeService : IIdentificationTypeService
    {
        private readonly ILogger<IdentificationTypeService> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public IdentificationTypeService(ILogger<IdentificationTypeService> logger,
                                         IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public void Add(IdentificationType entity)
        {
            _unitOfWork.IdentificationTypes.Add(entity);
            _unitOfWork.Complete();
        }

        public void AddRange(IEnumerable<IdentificationType> entities)
        {
            throw new NotImplementedException();
        }

        public int Count(IdentificationType entity)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentificationType> Find(Expression<Func<IdentificationType, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IdentificationType> GetAll()
        {
            return _unitOfWork.IdentificationTypes.GetAll();
        }

        public IdentificationType GetById(int id)
        {
            return _unitOfWork.IdentificationTypes.GetById(id);
        }

        public void Remove(IdentificationType entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            _unitOfWork.IdentificationTypes.Remove(id);
            _unitOfWork.Complete();
        }

        public void RemoveRage(IEnumerable<IdentificationType> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, IdentificationType entity)
        {
            _unitOfWork.IdentificationTypes.Update(id, entity);
            _unitOfWork.Complete();
        }
    }
}
