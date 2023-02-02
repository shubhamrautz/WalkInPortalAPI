using System;
using System.Collections.Generic;

namespace WalkInPortalAPI.Models
{
    public partial class ExpertiseTechnology
    {
        public int Id { get; set; }
        public int ExperienceId { get; set; }
        public int? TechnologyId { get; set; }
        public string? OtherTechnology { get; set; }

        public virtual Experience Experience { get; set; } = null!;
        public virtual Technology? Technology { get; set; }
    }
}
