using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class TalksViewModel
    {
        public int Id { get; set; }
        public int SpeakerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Edition { get; set; }

        public virtual Speakers Speaker { get; set; }
        //public virtual ICollection<Schedules> Schedules { get; set; }
    }
}
