using Conference.Data;
using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Conference.Services
{
    public interface ISpeakerService
    {
        IEnumerable<Speakers> GetSpeakers();
        Speakers GetSpeakerById(int id);
        Speakers AddSpeaker(Speakers speakerToBeAdded);
        Speakers UpdateSpeaker(Speakers speakerToUpdate);
        bool IsUniqueSpeaker(string name);
        void DeleteSpeaker(Speakers speakerToDelete);
        void Save();
    }
    public class SpeakerService : ISpeakerService
    {
        private readonly ISpeakersRepository speakerRepository;
        public SpeakerService(ISpeakersRepository speakersR)
        {
            this.speakerRepository = speakersR;
        }
        public IEnumerable<Speakers> GetSpeakers()
        {
            return speakerRepository.GetAllSpeakers();
        }
        public Speakers GetSpeakerById(int id)
        {
            var getById = speakerRepository.GetSpeakersById(id);
            return getById;
        }
        public Speakers AddSpeaker(Speakers speakerToAdd)
        {
            return speakerRepository.AddSpeaker(speakerToAdd);
        }
        public Speakers UpdateSpeaker(Speakers speakerToUpdate)
        {
            return speakerRepository.Update(speakerToUpdate);
        }
        public bool IsUniqueSpeaker(string name)
        {
            return speakerRepository.IsUniqueSpeaker(name);
        }
        public void DeleteSpeaker(Speakers speaker)
        {
            speakerRepository.Delete(speaker);

        }
        public void Save()
        {
            speakerRepository.Save();
        }
    }
}
