using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISponsorTypesService
    {
        IEnumerable<SponsorTypes> GetAllSponsorTypes();
        SponsorTypes GetSponsorTypeById(int id);
        SponsorTypes CreateSponsorType(SponsorTypes sponsorTypeToAdd);
        SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate);
        bool IsUniqueSponsorType(string name);
        void DeleteSponsorType(SponsorTypes sponsorType);
        void Save();
    }
    public class SponsorTypesService : ISponsorTypesService
    {
        private readonly ISponsorTypesRepository sponsorTypesRepository;
        public SponsorTypesService(ISponsorTypesRepository repository)
        {
            this.sponsorTypesRepository = repository;
        }
        public IEnumerable<SponsorTypes> GetAllSponsorTypes()
        {
            return sponsorTypesRepository.GetSponsorTypes();
        }
        public SponsorTypes GetSponsorTypeById(int id)
        {
            var getById = sponsorTypesRepository.GetSponsorTypeById(id);
            return getById;
        }
        public SponsorTypes CreateSponsorType(SponsorTypes sponsorTypeToAdd)
        {
            return sponsorTypesRepository.CreateSponsorType(sponsorTypeToAdd);
        }
        public SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypeToUpdate)
        {
            return sponsorTypesRepository.UpdateSponsorType(sponsorTypeToUpdate);
        }
        public bool IsUniqueSponsorType(string name)
        {
            return sponsorTypesRepository.IsUniqueSponsorType(name);
        }
        public void DeleteSponsorType(SponsorTypes sponsorType)
        {
            sponsorTypesRepository.DeleteSponsorType(sponsorType);

        }
        public void Save()
        {
            sponsorTypesRepository.Save();
        }
    }
}
