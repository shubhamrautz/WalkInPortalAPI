using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class Technology
    {
        public Technology()
        {
            ExpertiseTechnologies = new HashSet<ExpertiseTechnology>();
            UserFamiliarTechnologies = new HashSet<UserFamiliarTechnology>();
        }

        public int Id { get; set; }
        public string Technology1 { get; set; } = null!;

        public virtual ICollection<ExpertiseTechnology> ExpertiseTechnologies { get; set; }
        public virtual ICollection<UserFamiliarTechnology> UserFamiliarTechnologies { get; set; }
    }
}
