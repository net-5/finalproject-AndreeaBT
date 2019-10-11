using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface IEditionsServices
    {
        IEnumerable<Editions> GetEditions();
        Editions GetById(int id);
        Editions AddEditions(Editions editionToAdd);
        Editions Update(Editions editionToUpdate);
        bool IsUniqueName(string name);
        void DeleteEdition(Editions editions);
        void Save();
    }
    public class EditionService : IEditionsServices
    {
        private readonly IEditionRepository editionsRepository;
        public EditionService(IEditionRepository repository)
        {
            this.editionsRepository = repository;
        }
        public IEnumerable<Editions> GetEditions()
        {
            return editionsRepository.GetAllEditions();
        }
        public Editions GetById(int id)
        {
            var getById = editionsRepository.GetEditionById(id);
            return getById;
        }
        public Editions AddEditions(Editions editionToAdd)
        {
            return editionsRepository.AddEdition(editionToAdd);
        }
        public Editions Update(Editions editionToUpdate)
        {
            return editionsRepository.Update(editionToUpdate);
        }
        public bool IsUniqueName(string name)
        {
            return editionsRepository.IsUniqueEdition(name);
        }
        public void DeleteEdition(Editions editions)
        {
            editionsRepository.Delete(editions);

        }
        public void Save()
        {
            editionsRepository.Save();
        }
    }
}
