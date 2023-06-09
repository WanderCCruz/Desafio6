﻿using DesafioAlura.Entidades;
using DesafioAlura.Interfaces;

namespace DesafioAlura.Servicos
{
    public class AbrigoService
    {
        private readonly IRepository<Abrigo> _repository;

        public AbrigoService(IRepository<Abrigo> repository)
        {
            _repository = repository;
        }
        public void Add(Abrigo entity)
        {
           _repository.Add(entity);
        }

        public void Delete(Abrigo entity)
        {
            _repository.Delete(entity);
        }

        public IEnumerable<Abrigo> GetAll()
        {
            return _repository.GetAll();
        }

        public Abrigo GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Abrigo GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Update(Abrigo entity)
        {
            _repository.Update(entity);
        }
    }
}
