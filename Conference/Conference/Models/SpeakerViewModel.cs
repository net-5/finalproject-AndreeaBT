using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class SpeakerViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Email { get; set; }
        public string LinkedIn { get; set; }
        public string Skype { get; set; }
        public string GitHub { get; set; }
        public string Twitter { get; set; }
        public string CompanyName { get; set; }
        public string CompanyWebsite { get; set; }
        public string Description { get; set; }
        public string PageSlug { get; set; }
        public string Edition { get; set; }

        //public virtual ICollection<Photos> Photos { get; set; }
        //public virtual ICollection<Talks> Talks { get; set; }
        //public virtual ICollection<Workshops> Workshops { get; set; }

        //public string Name()
        //{
        //    return FirstName + " " + LastName;
        //}
    }

}
