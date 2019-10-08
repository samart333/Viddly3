using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viddly3.Models;

namespace Viddly3.ViewModels
{
    public class MemberFormViewModel
    {
        public IEnumerable <MembershipType> MembershipTypes { get; set; }

        public Member Member { get; set; }

    }
}