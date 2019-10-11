using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conference.Data
{
    public interface ISponsorTypesRepository
    {
        List<SponsorTypes> GetSponsorTypes();
        SponsorTypes GetSponsorTypeById(int id);
        SponsorTypes CreateSponsorType(SponsorTypes sponsorTypeToAdd);
        SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypesToUpdate);
        bool IsUniqueSponsorType(string name);
        void DeleteSponsorType(SponsorTypes sponsorTypes);
        void Save();
    }
    public class SponsorTypesRepository : ISponsorTypesRepository
    {
        private readonly ConferenceContext conferenceContext;
        public SponsorTypesRepository(ConferenceContext conferenceContext)
        {
            this.conferenceContext = conferenceContext;
        }
        public List<SponsorTypes> GetSponsorTypes()
        {
            return conferenceContext.SponsorTypes.ToList();
        }
        public SponsorTypes CreateSponsorType(SponsorTypes sponsorTypeToBeAdded)
        {
            var addedSponsorType = conferenceContext.Add(sponsorTypeToBeAdded);
            conferenceContext.SaveChanges();
            return addedSponsorType.Entity;
        }


        public SponsorTypes GetSponsorTypeById(int id)
        {
            return conferenceContext.SponsorTypes.Find(id);
        }


        public SponsorTypes UpdateSponsorType(SponsorTypes sponsorTypesToUpdate)
        {
            var updatedSponsorType = conferenceContext.Update(sponsorTypesToUpdate);
            conferenceContext.SaveChanges();
            return updatedSponsorType.Entity;
        }
        public bool IsUniqueSponsorType(string sponsorTypeName)
        {
            int nr = conferenceContext.Sponsors.Count(x => x.Name == sponsorTypeName);
            if (nr == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteSponsorType(SponsorTypes sponsorTypesToDelete)
        {
            sponsorTypesToDelete = conferenceContext.SponsorTypes.Find(sponsorTypesToDelete.Id);
            conferenceContext.SponsorTypes.Remove(sponsorTypesToDelete);

        }
        public void Save()
        {
            conferenceContext.SaveChanges();
        }
    }
}
