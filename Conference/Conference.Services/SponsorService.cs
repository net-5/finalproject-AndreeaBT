using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISponsorService
    {
        IEnumerable<Sponsors> GetAllSponsors();
        Sponsors GetSponsorById(int id);
        Sponsors CreateSponsor(Sponsors sponsorToAdd);
        Sponsors UpdateSponsor(Sponsors sponsorToUpdate);
        bool IsUniqueSponsor(string name);
        void DeleteSponsor(Sponsors sponsors);
        void Save();
    }
    public class SponsorService : ISponsorService
    {
        private readonly ISponsorRepository sponsorRepository;
        public SponsorService(ISponsorRepository repository)
        {
            this.sponsorRepository = repository;
        }
        public IEnumerable<Sponsors> GetAllSponsors()
        {
            return sponsorRepository.GetAllSponsors();
        }
        public Sponsors GetSponsorById(int id)
        {
            var getById = sponsorRepository.GetSponsorById(id);
            return getById;
        }
        public Sponsors CreateSponsor(Sponsors sponsorToAdd)
        {
            return sponsorRepository.CreateSponsor(sponsorToAdd);
        }
        public Sponsors UpdateSponsor(Sponsors sponsorToUpdate)
        {
            return sponsorRepository.UpdateSponsor(sponsorToUpdate);
        }
        public bool IsUniqueSponsor(string name)
        {
            return sponsorRepository.IsUniqueSponsor(name);
        }
        public void DeleteSponsor(Sponsors sponsors)
        {
            sponsorRepository.DeleteSponsor(sponsors);

        }
        public void Save()
        {
            sponsorRepository.Save();
        }
    }
}
