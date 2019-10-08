using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Viddly3.Models
{
    public class Member
    {

        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }

        public int Age { get; set; }

        public string Sex { get; set; }

        public string Company { get; set; }

        public int Id { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipType MembershipType { get; set; }


    }
}