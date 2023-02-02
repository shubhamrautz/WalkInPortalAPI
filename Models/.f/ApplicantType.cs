using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class ApplicantType
    {
        public ApplicantType()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Applicant { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
