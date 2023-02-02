using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class College
    {
        public College()
        {
            Educations = new HashSet<Education>();
        }

        public int Id { get; set; }
        public string CollegeName { get; set; } = null!;

        public virtual ICollection<Education> Educations { get; set; }
    }
}
